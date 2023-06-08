using CommandLine;

namespace Application.Console
{
    class Options
    {
        [Value(0)]
        public string Pattern { get; set; } = string.Empty;

        [Value(1)]
        public IEnumerable<string> InputFiles { get; set; } = new List<string>();
    }
}
