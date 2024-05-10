using CommandLineParser.Options;
using System.Text;

namespace CommandLineParser.Client;
public static class CandidateProcessor
{
    public static void Process(CandidateOptions candidateOptions)
    {
        var sb = new StringBuilder($"Thank you {candidateOptions.FirstName} {candidateOptions.LastName} for applying for the position ({candidateOptions.PositionReferenceNumber}).");

        sb.Append(Environment.NewLine);
        sb.Append(Environment.NewLine);
        sb.Append("We will be in touch shortly to progress.");

        Console.WriteLine(sb.ToString());
    }
}
