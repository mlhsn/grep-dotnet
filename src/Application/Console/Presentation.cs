
using Domain.DTO;

namespace Application.Console
{
    public struct PresentationLogic
    {
        public Boolean showFile { get; set; }
    }

    public class Presentation
    {
        public static void DisplayListOfResult(List<Result> results, PresentationLogic logic)
        {
            String presentable = "";

            results.ForEach((Result result) =>
            {
                if (!string.IsNullOrEmpty(presentable))
                {
                    presentable += "\n";
                }
                presentable += (logic.showFile ? result.fileName + ": " : "") + result.container;
            });

            System.Console.WriteLine(presentable);
        }
    }

}
