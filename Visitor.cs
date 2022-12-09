using System.Diagnostics;
using Antlr4.Runtime.Misc;
using FizzleCompiler.Content;
using static FizzleCompiler.Content.FizzleParser;

namespace FizzleCompiler
{
    // TODO: Implement
    // public class Value
    // {
    //     private bool isconst;
    //     private object? value;
    //     private TypeEnum
    // }
    public class Visitor : FizzleBaseVisitor<object?>
    {
        Dictionary<string, object?> Variables { get; } = new();

        public Visitor()
        {
            Variables["PI"] = Math.PI;
            Variables["E"] = Math.E;
            Variables["Write"] = new Func<object?[], object?>(Write);
        }

        private object? Write(object?[] args)
        {
            for (int i = 0; i < args.Length; i++)
            {
                object? arg = args[i];
                Console.WriteLine(arg);
            }

            return null;
        }
        public override object? VisitFunctionCall(FunctionCallContext context)
        {
            var name = context.IDENTIFIER().GetText();
            var args = context.expression().Select(Visit).ToArray();

            if (!Variables.ContainsKey(name))
                throw new Exception($"Function {name} is not defined.");

            if (!(Variables[name] is Func<object?[], object?> func))
                throw new Exception($"Variable {name} is not a function.");

            return func(args);

        }
        public override object? VisitAssignment(AssignmentContext context)
        {
            var varName = context.IDENTIFIER().GetText();
            var value = Visit(context.expression());
            Variables[varName] = value;
            // #if DEBUG
            //             Console.WriteLine($"{Variables[varName]!.ToString() ?? $"{Variables[varName]} is null"}");
            // #endif
            return null;
        }
        public override object? VisitIdentiferExpression(IdentiferExpressionContext context)
        {
            var varName = context.IDENTIFIER().GetText();

            if (!Variables.ContainsKey(varName))
                throw new Exception($"Variable {varName} is not defined");

            return Variables[varName];
        }
        public override object? VisitMultiplicativeExpression(MultiplicativeExpressionContext context)
        {
            var left = Visit(context.expression(0));
            var right = Visit(context.expression(1));
            var op = context.multOp().GetText();

            return op switch
            {
                "*" => Multiply(left, right),
                "/" => Divide(left, right),
                _ => throw new NotImplementedException()
            };
        }
        public override object? VisitAdditiveExpression(AdditiveExpressionContext context)
        {
            var left = Visit(context.expression(0));
            var right = Visit(context.expression(1));
            var op = context.addOp().GetText();

            return op switch
            {
                "+" => Add(left, right),
                "-" => Subtract(left, right),
                _ => throw new NotImplementedException()
            };
        }
        public override object? VisitConstant(ConstantContext context)
        {
            if (context.INTEGER() is { } i)
                return int.Parse(i.GetText());
            if (context.FLOAT() is { } f)
                return float.Parse(f.GetText());
            if (context.STRING() is { } s)
                return s.GetText()[1..^1];
            if (context.BOOL() is { } b)
                return b.GetText() == "true";
            if (context.NULL() is { })
                return null;

            throw new NotImplementedException("Unknown Value Type");
        }
        private object? Add(object? left, object? right)
        {
            if (left is int l && right is int r) return l + r;
            if (left is float lf && right is float rf) return lf + rf;
            if (left is int lInt && right is float rFloat) return lInt + rFloat;
            if (left is float lFloat && right is int rInt) return lFloat + rInt;
            if (left is string || right is string) return $"{left}{right}";

            throw new Exception($"Cannot add values of types {left?.GetType()} and {right?.GetType()}.");
        }
        private object? Subtract(object? left, object? right)
        {
            if (left is int l && right is int r) return l - r;
            if (left is float lf && right is float rf) return lf - rf;
            if (left is int lInt && right is float rFloat) return lInt - rFloat;
            if (left is float lFloat && right is int rInt) return lFloat - rInt;
            if (left is string || right is string) return $"{left}{right}";
            throw new Exception($"Cannot add values of types {left?.GetType()} and {right?.GetType()}.");
        }
        private object? Multiply(object? left, object? right)
        {
            if (left is int l && right is int r) return l * r;
            if (left is float lf && right is float rf) return lf * rf;
            if (left is int lInt && right is float rFloat) return lInt * rFloat;
            if (left is float lFloat && right is int rInt) return lFloat * rInt;
            if (left is string || right is string) return $"{left}{right}";
            throw new Exception($"Cannot add values of types {left?.GetType()} and {right?.GetType()}.");
        }
        private object? Divide(object? left, object? right)
        {
            if (left is int l && right is int r) return l / r;
            if (left is float lf && right is float rf) return lf / rf;
            if (left is int lInt && right is float rFloat) return lInt / rFloat;
            if (left is float lFloat && right is int rInt) return lFloat / rInt;
            if (left is string || right is string) return $"{left}{right}";
            throw new Exception($"Cannot add values of types {left?.GetType()} and {right?.GetType()}.");
        }
        // private object? Modulo(object? left, object? right)
        // {
        //     if (left is int l && right is int r) return l % r;
        //     if (left is float lf && right is float rf) return lf % rf;
        //     if (left is int lInt && right is float rFloat) return lInt % rFloat;
        //     if (left is float lFloat && right is int rInt) return lFloat % rInt;
        //     if (left is string || right is string) return $"{left}{right}";
        //     throw new Exception($"Cannot add values of types {left?.GetType()} and {right?.GetType()}.");
        // }

        public override object? VisitWhileBlock(WhileBlockContext context)
        {
            Func<object?, bool> condition = context.WHILE().GetText() == "while" ? IsTrue : IsFalse;
            if (condition(Visit(context.expression())))
            {
                do
                {
                    Visit(context.block());
                } while (condition(Visit(context.expression())));
            }
            else
                Visit(context.elseIfBlock());


            return null;
        }
        public override object? VisitComparisonExpression(ComparisonExpressionContext context)
        {
            var left = Visit(context.expression(0));
            var right = Visit(context.expression(1));

            var op = context.compareOp().GetText();

            return op switch
            {
                // "==" => IsEquals(left, right),
                // "!=" => NotEquals(left, right),
                ">" => GreaterThan(left, right),
                "<" => LessThan(left, right),
                // ">=" => GreaterThanOrEqual(left, right),
                // "<=" => LessThanOrEqual(left, right),
                _ => throw new NotImplementedException("You fucked up")
            };

        }
        private bool GreaterThan(object? left, object? right)
        {
            if (left is int l && right is int r) return l > r;
            if (left is float lf && right is float rf) return lf > rf;
            if (left is int lInt && right is float rFloat) return lInt > rFloat;
            if (left is float lFloat && right is int rInt) return lFloat > rInt;

            throw new Exception($"Cannot compare values of types {left?.GetType()} and {right?.GetType()}.");
        }

        private bool LessThan(object? left, object? right)
        {
            if (left is int l && right is int r) return l < r;
            if (left is float lf && right is float rf) return lf < rf;
            if (left is int lInt && right is float rFloat) return lInt < rFloat;
            if (left is float lFloat && right is int rInt) return lFloat < rInt;
            throw new Exception($"Cannot compare values of types {left?.GetType()} and {right?.GetType()}.");
        }

        private bool IsTrue(object? value)
        {
            if (value is bool b) return b;
            // if (value is int i) return i != 0;

            throw new Exception("Value is not a bool.");
        }
        private bool IsFalse(object? value) => !IsTrue(value);
    }
}