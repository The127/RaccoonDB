//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.9.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from C:/Users/julia/RiderProjects/RaccoonDB/RaccoonDB\RaccoonSQL.g4 by ANTLR 4.9.1

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using IToken = Antlr4.Runtime.IToken;
using ParserRuleContext = Antlr4.Runtime.ParserRuleContext;

/// <summary>
/// This class provides an empty implementation of <see cref="IRaccoonSQLVisitor{Result}"/>,
/// which can be extended to create a visitor which only needs to handle a subset
/// of the available methods.
/// </summary>
/// <typeparam name="Result">The return type of the visit operation.</typeparam>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.9.1")]
[System.Diagnostics.DebuggerNonUserCode]
[System.CLSCompliant(false)]
public partial class RaccoonSQLBaseVisitor<Result> : AbstractParseTreeVisitor<Result>, IRaccoonSQLVisitor<Result> {
	/// <summary>
	/// Visit a parse tree produced by <see cref="RaccoonSQLParser.query"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitQuery([NotNull] RaccoonSQLParser.QueryContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="RaccoonSQLParser.createQuery"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitCreateQuery([NotNull] RaccoonSQLParser.CreateQueryContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="RaccoonSQLParser.ifNotExists"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitIfNotExists([NotNull] RaccoonSQLParser.IfNotExistsContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="RaccoonSQLParser.dropQuery"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitDropQuery([NotNull] RaccoonSQLParser.DropQueryContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="RaccoonSQLParser.ifExists"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitIfExists([NotNull] RaccoonSQLParser.IfExistsContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="RaccoonSQLParser.alterQuery"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitAlterQuery([NotNull] RaccoonSQLParser.AlterQueryContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="RaccoonSQLParser.explainQuery"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitExplainQuery([NotNull] RaccoonSQLParser.ExplainQueryContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="RaccoonSQLParser.explainColumnsOnTable"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitExplainColumnsOnTable([NotNull] RaccoonSQLParser.ExplainColumnsOnTableContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="RaccoonSQLParser.explainIndicesOnTable"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitExplainIndicesOnTable([NotNull] RaccoonSQLParser.ExplainIndicesOnTableContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="RaccoonSQLParser.truncateQuery"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitTruncateQuery([NotNull] RaccoonSQLParser.TruncateQueryContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="RaccoonSQLParser.createIndex"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitCreateIndex([NotNull] RaccoonSQLParser.CreateIndexContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="RaccoonSQLParser.index"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitIndex([NotNull] RaccoonSQLParser.IndexContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="RaccoonSQLParser.indexColumns"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitIndexColumns([NotNull] RaccoonSQLParser.IndexColumnsContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="RaccoonSQLParser.indexColumn"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitIndexColumn([NotNull] RaccoonSQLParser.IndexColumnContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="RaccoonSQLParser.createTable"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitCreateTable([NotNull] RaccoonSQLParser.CreateTableContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="RaccoonSQLParser.table"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitTable([NotNull] RaccoonSQLParser.TableContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="RaccoonSQLParser.tableColumns"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitTableColumns([NotNull] RaccoonSQLParser.TableColumnsContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="RaccoonSQLParser.tableColumn"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitTableColumn([NotNull] RaccoonSQLParser.TableColumnContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="RaccoonSQLParser.columnConstraint"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitColumnConstraint([NotNull] RaccoonSQLParser.ColumnConstraintContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="RaccoonSQLParser.autoValue"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitAutoValue([NotNull] RaccoonSQLParser.AutoValueContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="RaccoonSQLParser.notNullConstraint"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitNotNullConstraint([NotNull] RaccoonSQLParser.NotNullConstraintContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="RaccoonSQLParser.uniqueConstraint"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitUniqueConstraint([NotNull] RaccoonSQLParser.UniqueConstraintContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="RaccoonSQLParser.primaryKeyConstraint"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPrimaryKeyConstraint([NotNull] RaccoonSQLParser.PrimaryKeyConstraintContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="RaccoonSQLParser.foreignKeyConstraint"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitForeignKeyConstraint([NotNull] RaccoonSQLParser.ForeignKeyConstraintContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="RaccoonSQLParser.addColumn"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitAddColumn([NotNull] RaccoonSQLParser.AddColumnContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="RaccoonSQLParser.dropColumn"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitDropColumn([NotNull] RaccoonSQLParser.DropColumnContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="RaccoonSQLParser.alterColumn"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitAlterColumn([NotNull] RaccoonSQLParser.AlterColumnContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="RaccoonSQLParser.selectQuery"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitSelectQuery([NotNull] RaccoonSQLParser.SelectQueryContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="RaccoonSQLParser.updateQuery"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitUpdateQuery([NotNull] RaccoonSQLParser.UpdateQueryContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="RaccoonSQLParser.deleteQuery"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitDeleteQuery([NotNull] RaccoonSQLParser.DeleteQueryContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="RaccoonSQLParser.insertQuery"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitInsertQuery([NotNull] RaccoonSQLParser.InsertQueryContext context) { return VisitChildren(context); }
}
