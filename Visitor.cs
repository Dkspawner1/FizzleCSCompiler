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
        public override object? VisitAssignment(AssignmentContext context)
        {
            var varName = context.IDENTIFIER().GetText();
            var value = Visit(context.expression());
            Variables[varName] = value;
            return null;
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
    }
}