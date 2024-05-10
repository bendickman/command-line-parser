using CommandLine;
using CommandLine.Text;
using CommandLineParser.Client;
using CommandLineParser.Options;

namespace CommandLineParser;

internal class Program
{
    static void Main(string[] args)
    {
        var parser = new Parser(with => with.HelpWriter = null);
        var parserResult = parser.ParseArguments<CandidateOptions>(args);

        parserResult
          .WithParsed(options => CandidateProcessor.Process(options))
          .WithNotParsed(errs => DisplayHelp(parserResult));
    }

    static void DisplayHelp<T>(ParserResult<T> result)
    {
        var helpText = HelpText.AutoBuild(result, h =>
        {
            h.AdditionalNewLineAfterOption = false;
            h.Heading = "Command Line Parser Client";
            h.Copyright = $"Copyright Ben Dickman {DateTime.UtcNow.Year}";

            return HelpText.DefaultParsingErrorsHandler(result, h);
        }, e => e);

        Console.WriteLine(helpText);
    }
}
