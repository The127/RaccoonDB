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
using IErrorNode = Antlr4.Runtime.Tree.IErrorNode;
using ITerminalNode = Antlr4.Runtime.Tree.ITerminalNode;
using IToken = Antlr4.Runtime.IToken;
using ParserRuleContext = Antlr4.Runtime.ParserRuleContext;

/// <summary>
/// This class provides an empty implementation of <see cref="IRaccoonSQLListener"/>,
/// which can be extended to create a listener which only needs to handle a subset
/// of the available methods.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.9.1")]
[System.Diagnostics.DebuggerNonUserCode]
[System.CLSCompliant(false)]
public partial class RaccoonSQLBaseListener : IRaccoonSQLListener {
	/// <summary>
	/// Enter a parse tree produced by <see cref="RaccoonSQLParser.query"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterQuery([NotNull] RaccoonSQLParser.QueryContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="RaccoonSQLParser.query"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitQuery([NotNull] RaccoonSQLParser.QueryContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="RaccoonSQLParser.createQuery"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCreateQuery([NotNull] RaccoonSQLParser.CreateQueryContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="RaccoonSQLParser.createQuery"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCreateQuery([NotNull] RaccoonSQLParser.CreateQueryContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="RaccoonSQLParser.ifNotExists"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterIfNotExists([NotNull] RaccoonSQLParser.IfNotExistsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="RaccoonSQLParser.ifNotExists"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitIfNotExists([NotNull] RaccoonSQLParser.IfNotExistsContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="RaccoonSQLParser.dropQuery"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDropQuery([NotNull] RaccoonSQLParser.DropQueryContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="RaccoonSQLParser.dropQuery"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDropQuery([NotNull] RaccoonSQLParser.DropQueryContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="RaccoonSQLParser.ifExists"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterIfExists([NotNull] RaccoonSQLParser.IfExistsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="RaccoonSQLParser.ifExists"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitIfExists([NotNull] RaccoonSQLParser.IfExistsContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="RaccoonSQLParser.alterQuery"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAlterQuery([NotNull] RaccoonSQLParser.AlterQueryContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="RaccoonSQLParser.alterQuery"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAlterQuery([NotNull] RaccoonSQLParser.AlterQueryContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="RaccoonSQLParser.explainQuery"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExplainQuery([NotNull] RaccoonSQLParser.ExplainQueryContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="RaccoonSQLParser.explainQuery"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExplainQuery([NotNull] RaccoonSQLParser.ExplainQueryContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="RaccoonSQLParser.explainColumnsOnTable"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExplainColumnsOnTable([NotNull] RaccoonSQLParser.ExplainColumnsOnTableContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="RaccoonSQLParser.explainColumnsOnTable"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExplainColumnsOnTable([NotNull] RaccoonSQLParser.ExplainColumnsOnTableContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="RaccoonSQLParser.explainIndicesOnTable"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExplainIndicesOnTable([NotNull] RaccoonSQLParser.ExplainIndicesOnTableContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="RaccoonSQLParser.explainIndicesOnTable"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExplainIndicesOnTable([NotNull] RaccoonSQLParser.ExplainIndicesOnTableContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="RaccoonSQLParser.truncateQuery"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTruncateQuery([NotNull] RaccoonSQLParser.TruncateQueryContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="RaccoonSQLParser.truncateQuery"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTruncateQuery([NotNull] RaccoonSQLParser.TruncateQueryContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="RaccoonSQLParser.createIndex"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCreateIndex([NotNull] RaccoonSQLParser.CreateIndexContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="RaccoonSQLParser.createIndex"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCreateIndex([NotNull] RaccoonSQLParser.CreateIndexContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="RaccoonSQLParser.index"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterIndex([NotNull] RaccoonSQLParser.IndexContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="RaccoonSQLParser.index"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitIndex([NotNull] RaccoonSQLParser.IndexContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="RaccoonSQLParser.indexColumns"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterIndexColumns([NotNull] RaccoonSQLParser.IndexColumnsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="RaccoonSQLParser.indexColumns"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitIndexColumns([NotNull] RaccoonSQLParser.IndexColumnsContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="RaccoonSQLParser.indexColumn"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterIndexColumn([NotNull] RaccoonSQLParser.IndexColumnContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="RaccoonSQLParser.indexColumn"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitIndexColumn([NotNull] RaccoonSQLParser.IndexColumnContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="RaccoonSQLParser.createTable"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCreateTable([NotNull] RaccoonSQLParser.CreateTableContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="RaccoonSQLParser.createTable"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCreateTable([NotNull] RaccoonSQLParser.CreateTableContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="RaccoonSQLParser.table"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTable([NotNull] RaccoonSQLParser.TableContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="RaccoonSQLParser.table"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTable([NotNull] RaccoonSQLParser.TableContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="RaccoonSQLParser.tableColumns"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTableColumns([NotNull] RaccoonSQLParser.TableColumnsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="RaccoonSQLParser.tableColumns"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTableColumns([NotNull] RaccoonSQLParser.TableColumnsContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="RaccoonSQLParser.tableColumn"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTableColumn([NotNull] RaccoonSQLParser.TableColumnContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="RaccoonSQLParser.tableColumn"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTableColumn([NotNull] RaccoonSQLParser.TableColumnContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="RaccoonSQLParser.columnConstraint"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterColumnConstraint([NotNull] RaccoonSQLParser.ColumnConstraintContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="RaccoonSQLParser.columnConstraint"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitColumnConstraint([NotNull] RaccoonSQLParser.ColumnConstraintContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="RaccoonSQLParser.autoValue"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAutoValue([NotNull] RaccoonSQLParser.AutoValueContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="RaccoonSQLParser.autoValue"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAutoValue([NotNull] RaccoonSQLParser.AutoValueContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="RaccoonSQLParser.notNullConstraint"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterNotNullConstraint([NotNull] RaccoonSQLParser.NotNullConstraintContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="RaccoonSQLParser.notNullConstraint"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitNotNullConstraint([NotNull] RaccoonSQLParser.NotNullConstraintContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="RaccoonSQLParser.uniqueConstraint"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterUniqueConstraint([NotNull] RaccoonSQLParser.UniqueConstraintContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="RaccoonSQLParser.uniqueConstraint"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitUniqueConstraint([NotNull] RaccoonSQLParser.UniqueConstraintContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="RaccoonSQLParser.primaryKeyConstraint"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPrimaryKeyConstraint([NotNull] RaccoonSQLParser.PrimaryKeyConstraintContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="RaccoonSQLParser.primaryKeyConstraint"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPrimaryKeyConstraint([NotNull] RaccoonSQLParser.PrimaryKeyConstraintContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="RaccoonSQLParser.foreignKeyConstraint"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterForeignKeyConstraint([NotNull] RaccoonSQLParser.ForeignKeyConstraintContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="RaccoonSQLParser.foreignKeyConstraint"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitForeignKeyConstraint([NotNull] RaccoonSQLParser.ForeignKeyConstraintContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="RaccoonSQLParser.addColumn"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAddColumn([NotNull] RaccoonSQLParser.AddColumnContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="RaccoonSQLParser.addColumn"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAddColumn([NotNull] RaccoonSQLParser.AddColumnContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="RaccoonSQLParser.dropColumn"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDropColumn([NotNull] RaccoonSQLParser.DropColumnContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="RaccoonSQLParser.dropColumn"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDropColumn([NotNull] RaccoonSQLParser.DropColumnContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="RaccoonSQLParser.alterColumn"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAlterColumn([NotNull] RaccoonSQLParser.AlterColumnContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="RaccoonSQLParser.alterColumn"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAlterColumn([NotNull] RaccoonSQLParser.AlterColumnContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="RaccoonSQLParser.selectQuery"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSelectQuery([NotNull] RaccoonSQLParser.SelectQueryContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="RaccoonSQLParser.selectQuery"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSelectQuery([NotNull] RaccoonSQLParser.SelectQueryContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="RaccoonSQLParser.updateQuery"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterUpdateQuery([NotNull] RaccoonSQLParser.UpdateQueryContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="RaccoonSQLParser.updateQuery"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitUpdateQuery([NotNull] RaccoonSQLParser.UpdateQueryContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="RaccoonSQLParser.deleteQuery"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDeleteQuery([NotNull] RaccoonSQLParser.DeleteQueryContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="RaccoonSQLParser.deleteQuery"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDeleteQuery([NotNull] RaccoonSQLParser.DeleteQueryContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="RaccoonSQLParser.insertQuery"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterInsertQuery([NotNull] RaccoonSQLParser.InsertQueryContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="RaccoonSQLParser.insertQuery"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitInsertQuery([NotNull] RaccoonSQLParser.InsertQueryContext context) { }

	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void EnterEveryRule([NotNull] ParserRuleContext context) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void ExitEveryRule([NotNull] ParserRuleContext context) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void VisitTerminal([NotNull] ITerminalNode node) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void VisitErrorNode([NotNull] IErrorNode node) { }
}
