using CommandLine;
using Domain.DTO;
using Domain.Services;

namespace GrepDotNet
{
    internal class GrepApplication
    {
        static void Main(string[] args)
        {
            Parser.Default.ParseArguments<Application.Console.Options>(args)
                .WithParsed((Application.Console.Options options) =>
                {
                    List<Result> results;
                    Search.ForPattern(new Request(options.Pattern, options.InputFiles.ToList<String>()), out results);

                    Console.WriteLine(results.Count());
                })
                .WithNotParsed(x => Console.WriteLine($"CommandLine error: {x.ToString()}"));
        }
    }
}
