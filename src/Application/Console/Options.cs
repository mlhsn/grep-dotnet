using CommandLine;

namespace Application.Console
{
    class Options
    {
        [Value(0, HelpText = "Pattern string to search", MetaName = "PATTERN", Required = true)]
        public string Pattern { get; set; } = string.Empty;

        [Value(1, HelpText = "File[s] to search for pattern", MetaName = "FILE[S]...", Required = true, Min = 1)]
        public IEnumerable<string> InputFiles { get; set; } = new List<string>();
    }
}
