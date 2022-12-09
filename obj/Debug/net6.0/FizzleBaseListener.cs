﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.6.6
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from c:\Users\Nicho\Desktop\C#\FizzleCompiler\Content\Fizzle.g4 by ANTLR 4.6.6

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace FizzleCompiler.Content {

using Antlr4.Runtime.Misc;
using IErrorNode = Antlr4.Runtime.Tree.IErrorNode;
using ITerminalNode = Antlr4.Runtime.Tree.ITerminalNode;
using IToken = Antlr4.Runtime.IToken;
using ParserRuleContext = Antlr4.Runtime.ParserRuleContext;

/// <summary>
/// This class provides an empty implementation of <see cref="IFizzleListener"/>,
/// which can be extended to create a listener which only needs to handle a subset
/// of the available methods.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.6.6")]
[System.CLSCompliant(false)]
public partial class FizzleBaseListener : IFizzleListener {
	/// <summary>
	/// Enter a parse tree produced by the <c>constantExpression</c>
	/// labeled alternative in <see cref="FizzleParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterConstantExpression([NotNull] FizzleParser.ConstantExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>constantExpression</c>
	/// labeled alternative in <see cref="FizzleParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitConstantExpression([NotNull] FizzleParser.ConstantExpressionContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>identiferExpression</c>
	/// labeled alternative in <see cref="FizzleParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterIdentiferExpression([NotNull] FizzleParser.IdentiferExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>identiferExpression</c>
	/// labeled alternative in <see cref="FizzleParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitIdentiferExpression([NotNull] FizzleParser.IdentiferExpressionContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>functionCallExpression</c>
	/// labeled alternative in <see cref="FizzleParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFunctionCallExpression([NotNull] FizzleParser.FunctionCallExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>functionCallExpression</c>
	/// labeled alternative in <see cref="FizzleParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFunctionCallExpression([NotNull] FizzleParser.FunctionCallExpressionContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>parenthesizedExpression</c>
	/// labeled alternative in <see cref="FizzleParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterParenthesizedExpression([NotNull] FizzleParser.ParenthesizedExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>parenthesizedExpression</c>
	/// labeled alternative in <see cref="FizzleParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitParenthesizedExpression([NotNull] FizzleParser.ParenthesizedExpressionContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>notExpression</c>
	/// labeled alternative in <see cref="FizzleParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterNotExpression([NotNull] FizzleParser.NotExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>notExpression</c>
	/// labeled alternative in <see cref="FizzleParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitNotExpression([NotNull] FizzleParser.NotExpressionContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>multiplicativeExpression</c>
	/// labeled alternative in <see cref="FizzleParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterMultiplicativeExpression([NotNull] FizzleParser.MultiplicativeExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>multiplicativeExpression</c>
	/// labeled alternative in <see cref="FizzleParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitMultiplicativeExpression([NotNull] FizzleParser.MultiplicativeExpressionContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>additiveExpression</c>
	/// labeled alternative in <see cref="FizzleParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAdditiveExpression([NotNull] FizzleParser.AdditiveExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>additiveExpression</c>
	/// labeled alternative in <see cref="FizzleParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAdditiveExpression([NotNull] FizzleParser.AdditiveExpressionContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>comparisonExpression</c>
	/// labeled alternative in <see cref="FizzleParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterComparisonExpression([NotNull] FizzleParser.ComparisonExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>comparisonExpression</c>
	/// labeled alternative in <see cref="FizzleParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitComparisonExpression([NotNull] FizzleParser.ComparisonExpressionContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>booleanExpression</c>
	/// labeled alternative in <see cref="FizzleParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterBooleanExpression([NotNull] FizzleParser.BooleanExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>booleanExpression</c>
	/// labeled alternative in <see cref="FizzleParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitBooleanExpression([NotNull] FizzleParser.BooleanExpressionContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="FizzleParser.program"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterProgram([NotNull] FizzleParser.ProgramContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="FizzleParser.program"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitProgram([NotNull] FizzleParser.ProgramContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="FizzleParser.line"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLine([NotNull] FizzleParser.LineContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="FizzleParser.line"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLine([NotNull] FizzleParser.LineContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="FizzleParser.statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterStatement([NotNull] FizzleParser.StatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="FizzleParser.statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitStatement([NotNull] FizzleParser.StatementContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="FizzleParser.ifBlock"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterIfBlock([NotNull] FizzleParser.IfBlockContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="FizzleParser.ifBlock"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitIfBlock([NotNull] FizzleParser.IfBlockContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="FizzleParser.elseIfBlock"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterElseIfBlock([NotNull] FizzleParser.ElseIfBlockContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="FizzleParser.elseIfBlock"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitElseIfBlock([NotNull] FizzleParser.ElseIfBlockContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="FizzleParser.whileBlock"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterWhileBlock([NotNull] FizzleParser.WhileBlockContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="FizzleParser.whileBlock"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitWhileBlock([NotNull] FizzleParser.WhileBlockContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="FizzleParser.assignment"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAssignment([NotNull] FizzleParser.AssignmentContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="FizzleParser.assignment"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAssignment([NotNull] FizzleParser.AssignmentContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="FizzleParser.functionCall"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFunctionCall([NotNull] FizzleParser.FunctionCallContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="FizzleParser.functionCall"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFunctionCall([NotNull] FizzleParser.FunctionCallContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="FizzleParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExpression([NotNull] FizzleParser.ExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="FizzleParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExpression([NotNull] FizzleParser.ExpressionContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="FizzleParser.multOp"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterMultOp([NotNull] FizzleParser.MultOpContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="FizzleParser.multOp"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitMultOp([NotNull] FizzleParser.MultOpContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="FizzleParser.addOp"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAddOp([NotNull] FizzleParser.AddOpContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="FizzleParser.addOp"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAddOp([NotNull] FizzleParser.AddOpContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="FizzleParser.compareOp"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCompareOp([NotNull] FizzleParser.CompareOpContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="FizzleParser.compareOp"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCompareOp([NotNull] FizzleParser.CompareOpContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="FizzleParser.boolOp"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterBoolOp([NotNull] FizzleParser.BoolOpContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="FizzleParser.boolOp"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitBoolOp([NotNull] FizzleParser.BoolOpContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="FizzleParser.constant"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterConstant([NotNull] FizzleParser.ConstantContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="FizzleParser.constant"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitConstant([NotNull] FizzleParser.ConstantContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="FizzleParser.block"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterBlock([NotNull] FizzleParser.BlockContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="FizzleParser.block"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitBlock([NotNull] FizzleParser.BlockContext context) { }

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
} // namespace FizzleCompiler.Content
