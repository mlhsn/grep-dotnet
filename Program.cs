using System;
using CommandLine;

namespace GrepDotNet
{
    internal class GrepApplication
    {
        static void Main(string[] args)
        {
            var parsedResults = Parser.Default.ParseArguments<Application.Console.Options>(args)
                .WithParsed((Application.Console.Options options) => {
                    System.Console.WriteLine(options.Pattern);
                    options.InputFiles.ToList<string>().ForEach(item => System.Console.WriteLine(item));
                })
                .WithNotParsed(x => System.Console.WriteLine(x.ToString()));
        }
    }
}
