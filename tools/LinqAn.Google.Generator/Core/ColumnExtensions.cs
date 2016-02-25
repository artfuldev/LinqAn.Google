using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Humanizer;

namespace LinqAn.Google.Generator.Core
{
    public static class ColumnExtensions
    {
        public static string ToClassName(this Column column)
        {
            var id = column.Id;
            var className = GetClassName(id);
            return className;
        }

        public static string GetClassName(this string id)
        {
            var className = id.Replace("ga:", "").Pascalize().Replace("ID", "Id");
            var match = Regex.Match(className, "^[0-9]+");
            if (!match.Success) return className;
            var number = match.ToString();
            var numberAsInt = Convert.ToInt32(number);
            var replacement = numberAsInt.ToWords().Dehumanize().Pascalize();
            var remaining = className.Replace(number, "").Pascalize();
            className = replacement + remaining;
            return className;
        }

        public static IEnumerable<TypeInfo> ToTypeInfos(this Column column)
        {
            if (!column.Attributes.IsTemplated)
            {
                yield return
                    new TypeInfo()
                    {
                        AllowedInSegments = column.Attributes.IsAllowedInSegments,
                        Description = column.Attributes.Description,
                        Id = column.Id,
                        Name = column.Attributes.UiName,
                        TypeName = column.Attributes.DestinationTypeName
                    };
                yield break;
            }
            var maxIndex =
                Convert.ToInt32(column.Attributes.PremiumMaxTemplateIndex ?? column.Attributes.MaxTemplateIndex);
            var minIndex =
                Convert.ToInt32(column.Attributes.PremiumMinTemplateIndex ?? column.Attributes.MinTemplateIndex);
            for (var i = minIndex; i <= maxIndex; i++)
            {
                yield return
                    new TypeInfo()
                    {
                        AllowedInSegments = column.Attributes.IsAllowedInSegments,
                        Description = column.Attributes.Description.Replace("XX", i.ToString()),
                        Id = column.Id.Replace("XX", i.ToString()),
                        Name = column.Attributes.UiName.Replace("XX", i.ToString()),
                        TypeName = column.Attributes.Type == "DIMENSION" ? "string" : "float"
                    };
            }
        }
    }
}