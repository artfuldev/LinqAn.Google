namespace DotNetAnalytics.Google.Generator
{
    public interface IFileContentGenerator
    {
        string GenerateFileContent(Column column);
    }
}