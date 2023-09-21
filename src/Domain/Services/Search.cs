using Domain.DTO;

namespace Domain.Services;

public class Search
{
    public static void ForPattern(in Request request, out List<Result> results)
    {
        results = new List<Result> { };

        foreach (var fileName in request.fileNameList)
        {
            if (!File.Exists(fileName))
            {
                throw new FileNotFoundException($"file `{fileName}` not found.");
            }

            using (StreamReader sr = File.OpenText(fileName))
            {
                String? line;
                while ((line = sr.ReadLine()) != null)
                {
                    if (line.Contains(request.pattern))
                    {
                        results.Add(new Result { container = line });
                    }
                }
            }
        }
    }
}
