using CommandLine;

namespace CommandLineParser.Options;
public class CandidateOptions
{
    [Option('f', "firstname", Required = true, HelpText = "Please enter your first name")]
    public string FirstName { get; set; } = string.Empty;

    [Option('l', "lastname", Required = true, HelpText = "Please enter your last name")]
    public string LastName { get; set; } = string.Empty;

    [Option('p', "positionreferencenumber", Required = true, HelpText = "Please enter the position reference number")]
    public string PositionReferenceNumber { get; set; } = string.Empty;
}
