namespace Domain.DTO
{
    public readonly record struct Request(String pattern, List<String> fileNameList);
}
