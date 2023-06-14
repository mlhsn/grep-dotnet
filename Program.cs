using CommandLine;

namespace GrepDotNet
{
    internal class GrepApplication
    {
        static void Main(string[] args)
        {
            Parser.Default.ParseArguments<Application.Console.Options>(args)
                .WithParsed((Application.Console.Options options) =>
                {
                    Console.WriteLine(options.Pattern);
                    options.InputFiles.ToList<string>().ForEach(item => Console.WriteLine(item));
                })
                .WithNotParsed(x => Console.WriteLine(x.ToString()));
        }
    }
}
