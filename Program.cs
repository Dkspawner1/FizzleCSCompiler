using Antlr4.Runtime;
using FizzleCompiler.Content;

namespace FizzleCompiler
{
    public class Program
    {
        private static readonly string FILE = "Content/test.fs";
        public static void Main(string[] args)
        {
            var fileContents = File.ReadAllText(FILE);
            var inputStream = new AntlrInputStream(fileContents);
            var fizzleLexer = new FizzleLexer(inputStream);
            var commonTokenStream = new CommonTokenStream(fizzleLexer);
            var fizzleParser = new FizzleParser(commonTokenStream);

            // TODO: add error handling here
            // fizzleParser.AddErrorListener

            var fizzleContext = fizzleParser.program();
            var visitor = new Visitor();

            visitor.Visit(fizzleContext);
        }
    }
}