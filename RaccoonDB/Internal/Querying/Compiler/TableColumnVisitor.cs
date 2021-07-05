using System;

namespace RaccoonDB.Internal.Querying.Compiler
{
    public class TableColumnModel
    {
        public string ColumnName { get; set; } = null!;
        public string ColumnType { get; set; } = null!;
        public bool NotNull { get; set; }
        public bool Unique { get; set; }
        public bool PrimaryKey { get; set; }
        public bool ForeignKey { get; set; }
        public string? ForeignTableName { get; set; }
        public string? ForeignColumnName { get; set; }
        public bool AutoValue { get; set; }

        public override string ToString() =>
            $"{nameof(TableColumnModel)}[" +
            $"{nameof(ColumnName)}: '{ColumnName}'," +
            $" {nameof(ColumnType)}: '{ColumnType}'," +
            $" {nameof(NotNull)}: '{NotNull}', " +
            $"{nameof(Unique)}: '{Unique}', " +
            $"{nameof(AutoValue)}: '{AutoValue}', " +
            $"{nameof(PrimaryKey)}: '{PrimaryKey}', " +
            $"{nameof(ForeignKey)}: '{ForeignKey}', " +
            $"{nameof(ForeignTableName)}: '{ForeignTableName}', " +
            $"{nameof(ForeignColumnName)}: '{ForeignColumnName}']";
    }
    
    public class TableColumnVisitor : RaccoonSQLBaseVisitor<TableColumnModel>
    {
        private readonly TableColumnModel _model = new(); 

        public override TableColumnModel VisitTableColumn(RaccoonSQLParser.TableColumnContext context)
        {
            _model.ColumnName = context.name.Text;
            _model.ColumnType = context.type.Text;
            VisitChildren(context);
            return _model;
        }

        public override TableColumnModel VisitNotNullConstraint(RaccoonSQLParser.NotNullConstraintContext context)
        {
            if(_model.PrimaryKey)
                throw new SqlCompilationException($"not null constraint is not allowed since primary key constraint already set on column {_model.ColumnName}", context);
            if (_model.NotNull) 
                throw new SqlCompilationException($"duplicate not null constraint on column {_model.ColumnName}", context);
            _model.NotNull = true;
            return _model;
        }

        public override TableColumnModel VisitUniqueConstraint(RaccoonSQLParser.UniqueConstraintContext context)
        { 
            if(_model.PrimaryKey)
                throw new SqlCompilationException($"unique constraint is not allowed since primary key constraint already set on column {_model.ColumnName}", context);
            if (_model.Unique) 
                throw new SqlCompilationException($"duplicate unique constraint on column {_model.ColumnName}", context);
            _model.Unique = true;
            return _model;
        }

        public override TableColumnModel VisitPrimaryKeyConstraint(RaccoonSQLParser.PrimaryKeyConstraintContext context)
        {
            if(_model.Unique)
                throw new SqlCompilationException($"primary key constraint is not allowed since unique constraint already set on column {_model.ColumnName}", context);
            if(_model.NotNull)
                throw new SqlCompilationException($"primary key constraint is not allowed since not null constraint already set on column {_model.ColumnName}", context);
            if(_model.PrimaryKey)
                throw new SqlCompilationException($"duplicate primary key constraint on column {_model.ColumnName}", context);
            _model.PrimaryKey = true;
            return _model;
        }

        public override TableColumnModel VisitForeignKeyConstraint(RaccoonSQLParser.ForeignKeyConstraintContext context)
        {
            if (_model.ForeignKey)
                throw new SqlCompilationException($"duplicate foreign key constraint on column {_model.ColumnName}", context);
            _model.ForeignKey = true;
            _model.ForeignTableName = context.tableName.Text;
            _model.ForeignColumnName = context.columnName.Text;
            return _model;
        }

        public override TableColumnModel VisitAutoValue(RaccoonSQLParser.AutoValueContext context)
        {
            if(_model.AutoValue)
                throw new SqlCompilationException($"duplicate auto constraint on column {_model.ColumnName}", context);
            _model.AutoValue = true;
            return _model;
        }
    }
}