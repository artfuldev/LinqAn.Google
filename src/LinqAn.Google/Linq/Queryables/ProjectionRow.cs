using LinqAn.Google.Records;

namespace LinqAn.Google.Linq.Queryables
{
    public abstract class ProjectionRow
    {
        public IRecord Record { get; protected set; }
        public abstract object GetValue(int index);
    }
}