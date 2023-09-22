using Application.Console;
using CommandLine;
using Domain.DTO;
using Domain.Services;

namespace GrepDotNet
{
    internal class GrepApplication
    {
        static void Main(string[] args)
        {
            Parser.Default.ParseArguments<Options>(args)
                .WithParsed((Options options) =>
                {
                    List<Result> results;
                    Search.ForPattern(new Request(options.Pattern, options.InputFiles.ToList<String>()), out results);

                    Presentation.DisplayListOfResult(results, new PresentationLogic { showFile = options.InputFiles.Count() > 1 });
                })
                .WithNotParsed(x => Console.WriteLine($"CommandLine error: {x.ToString()}"));
        }
    }
}
