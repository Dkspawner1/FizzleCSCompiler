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
using IParseTreeListener = Antlr4.Runtime.Tree.IParseTreeListener;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete listener for a parse tree produced by
/// <see cref="FizzleParser"/>.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.6.6")]
[System.CLSCompliant(false)]
public interface IFizzleListener : IParseTreeListener {
	/// <summary>
	/// Enter a parse tree produced by the <c>constantExpression</c>
	/// labeled alternative in <see cref="FizzleParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterConstantExpression([NotNull] FizzleParser.ConstantExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>constantExpression</c>
	/// labeled alternative in <see cref="FizzleParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitConstantExpression([NotNull] FizzleParser.ConstantExpressionContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>identiferExpression</c>
	/// labeled alternative in <see cref="FizzleParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIdentiferExpression([NotNull] FizzleParser.IdentiferExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>identiferExpression</c>
	/// labeled alternative in <see cref="FizzleParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIdentiferExpression([NotNull] FizzleParser.IdentiferExpressionContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>functionCallExpression</c>
	/// labeled alternative in <see cref="FizzleParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFunctionCallExpression([NotNull] FizzleParser.FunctionCallExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>functionCallExpression</c>
	/// labeled alternative in <see cref="FizzleParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFunctionCallExpression([NotNull] FizzleParser.FunctionCallExpressionContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>parenthesizedExpression</c>
	/// labeled alternative in <see cref="FizzleParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterParenthesizedExpression([NotNull] FizzleParser.ParenthesizedExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>parenthesizedExpression</c>
	/// labeled alternative in <see cref="FizzleParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitParenthesizedExpression([NotNull] FizzleParser.ParenthesizedExpressionContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>notExpression</c>
	/// labeled alternative in <see cref="FizzleParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNotExpression([NotNull] FizzleParser.NotExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>notExpression</c>
	/// labeled alternative in <see cref="FizzleParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNotExpression([NotNull] FizzleParser.NotExpressionContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>multiplicativeExpression</c>
	/// labeled alternative in <see cref="FizzleParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMultiplicativeExpression([NotNull] FizzleParser.MultiplicativeExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>multiplicativeExpression</c>
	/// labeled alternative in <see cref="FizzleParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMultiplicativeExpression([NotNull] FizzleParser.MultiplicativeExpressionContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>additiveExpression</c>
	/// labeled alternative in <see cref="FizzleParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAdditiveExpression([NotNull] FizzleParser.AdditiveExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>additiveExpression</c>
	/// labeled alternative in <see cref="FizzleParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAdditiveExpression([NotNull] FizzleParser.AdditiveExpressionContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>comparisonExpression</c>
	/// labeled alternative in <see cref="FizzleParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterComparisonExpression([NotNull] FizzleParser.ComparisonExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>comparisonExpression</c>
	/// labeled alternative in <see cref="FizzleParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitComparisonExpression([NotNull] FizzleParser.ComparisonExpressionContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>booleanExpression</c>
	/// labeled alternative in <see cref="FizzleParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBooleanExpression([NotNull] FizzleParser.BooleanExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>booleanExpression</c>
	/// labeled alternative in <see cref="FizzleParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBooleanExpression([NotNull] FizzleParser.BooleanExpressionContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="FizzleParser.program"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterProgram([NotNull] FizzleParser.ProgramContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="FizzleParser.program"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitProgram([NotNull] FizzleParser.ProgramContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="FizzleParser.line"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLine([NotNull] FizzleParser.LineContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="FizzleParser.line"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLine([NotNull] FizzleParser.LineContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="FizzleParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStatement([NotNull] FizzleParser.StatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="FizzleParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStatement([NotNull] FizzleParser.StatementContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="FizzleParser.ifBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIfBlock([NotNull] FizzleParser.IfBlockContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="FizzleParser.ifBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIfBlock([NotNull] FizzleParser.IfBlockContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="FizzleParser.elseIfBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterElseIfBlock([NotNull] FizzleParser.ElseIfBlockContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="FizzleParser.elseIfBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitElseIfBlock([NotNull] FizzleParser.ElseIfBlockContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="FizzleParser.whileBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterWhileBlock([NotNull] FizzleParser.WhileBlockContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="FizzleParser.whileBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitWhileBlock([NotNull] FizzleParser.WhileBlockContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="FizzleParser.assignment"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAssignment([NotNull] FizzleParser.AssignmentContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="FizzleParser.assignment"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAssignment([NotNull] FizzleParser.AssignmentContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="FizzleParser.functionCall"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFunctionCall([NotNull] FizzleParser.FunctionCallContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="FizzleParser.functionCall"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFunctionCall([NotNull] FizzleParser.FunctionCallContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="FizzleParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExpression([NotNull] FizzleParser.ExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="FizzleParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExpression([NotNull] FizzleParser.ExpressionContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="FizzleParser.multOp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMultOp([NotNull] FizzleParser.MultOpContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="FizzleParser.multOp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMultOp([NotNull] FizzleParser.MultOpContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="FizzleParser.addOp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAddOp([NotNull] FizzleParser.AddOpContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="FizzleParser.addOp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAddOp([NotNull] FizzleParser.AddOpContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="FizzleParser.compareOp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCompareOp([NotNull] FizzleParser.CompareOpContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="FizzleParser.compareOp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCompareOp([NotNull] FizzleParser.CompareOpContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="FizzleParser.boolOp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBoolOp([NotNull] FizzleParser.BoolOpContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="FizzleParser.boolOp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBoolOp([NotNull] FizzleParser.BoolOpContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="FizzleParser.constant"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterConstant([NotNull] FizzleParser.ConstantContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="FizzleParser.constant"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitConstant([NotNull] FizzleParser.ConstantContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="FizzleParser.block"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBlock([NotNull] FizzleParser.BlockContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="FizzleParser.block"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBlock([NotNull] FizzleParser.BlockContext context);
}
} // namespace FizzleCompiler.Content
