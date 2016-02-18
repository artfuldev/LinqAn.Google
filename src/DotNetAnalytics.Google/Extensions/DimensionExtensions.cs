using System;
using System.Collections.Generic;
using System.Linq;
using DotNetAnalytics.Google.Dimensions;

namespace DotNetAnalytics.Google.Extensions
{
    /// <summary>
    ///     Useful extensions for the <seealso cref="IDimension"/>.
    /// </summary>
    public static class DimensionExtensions
    {
        public static string ToStringRepresentation(this IEnumerable<IDimension> dimensions)
        {
            if (dimensions == null)
                throw new ArgumentNullException(nameof(dimensions), "dimensions cannot be null");
            return string.Join(",", dimensions.Select(x => x.Id));
        }
    }
}