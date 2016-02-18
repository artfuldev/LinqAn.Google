namespace DotNetAnalytics.Google.Generator
{
    public interface IFileContentGenerator
    {
        string GetFileName(Column column);
        string GenerateFileContent(Column column);
    }
}