namespace LinqAn.Google.Generator.Core
{
    public class TypeInfo : ITypeInfo
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool AllowedInSegments { get; set; }
        public string TypeName { get; set; }

        public override string ToString() => $"{Id} : {Name} : {TypeName}";
    }
}