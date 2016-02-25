namespace LinqAn.Google.Generator.Core
{
    public interface ITypeDetails
    {
        bool AllowedInSegments { get; }
        string Description { get; }
        string Id { get; }
        string Name { get; }
        string TypeName { get; }
    }
}