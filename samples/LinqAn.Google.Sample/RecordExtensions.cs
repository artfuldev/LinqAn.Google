using System;
using System.Linq;
using LinqAn.Google.Records;

namespace LinqAn.Google.Sample
{
    public static class RecordExtensions
    {
        public static string ToStringRepresentation(this IRecord record)
        {
            return record.GetType().GetProperties().Where(propertyInfo =>
            {
                var value = propertyInfo.GetValue(record);
                return value != null &&
                       value.ToString() != ((object) new DateTime()).ToString() &&
                       value.ToString() != ((object) 0).ToString() &&
                       value.ToString() != ((object) 0F).ToString() &&
                       value.ToString() != ((object) 0M).ToString() &&
                       value.ToString() != ((object) TimeSpan.Zero).ToString();
            })
                .Select(propertyInfo => propertyInfo.GetValue(record))
                .Aggregate("", (current, value) => current + (value + "\n"));
        }
    }
}