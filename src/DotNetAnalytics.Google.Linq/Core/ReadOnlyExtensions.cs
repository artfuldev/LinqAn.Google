using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace DotNetAnalytics.Google.Linq.Core
{
    public static class ReadOnlyExtensions
    {
        public static ReadOnlyCollection<T> AsReadOnly<T>(this IList<T> list)
        {
            return new ReadOnlyCollection<T>(list);
        }

        public static ReadOnlyCollection<T> ToReadOnly<T>(this IEnumerable<T> collection)
        {
            if (ReferenceEquals(null, collection)) return EmptyReadOnlyCollection<T>.Empty;
            return collection as ReadOnlyCollection<T> ?? (new List<T>(collection).AsReadOnly());
        }

        class EmptyReadOnlyCollection<T>
        {
            internal static readonly ReadOnlyCollection<T> Empty = new List<T>().AsReadOnly();
        }
    }
}
