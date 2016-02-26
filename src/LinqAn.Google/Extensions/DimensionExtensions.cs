using System;
using System.Collections.Generic;
using LinqAn.Google.Dimensions;
using System.Linq;

namespace LinqAn.Google.Extensions
{
    /// <summary>
    ///     Useful extensions for the <seealso cref="IDimension" />.
    /// </summary>
    internal static class DimensionExtensions
    {
        public static string ToStringRepresentation(this IEnumerable<IDimension> dimensions)
        {
            if (dimensions == null)
                throw new ArgumentNullException(nameof(dimensions), "dimensions cannot be null");
            return string.Join(",", dimensions.Select(x => x.Id));
        }
    }
}