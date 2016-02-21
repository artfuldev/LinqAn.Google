using System;
using System.Text.RegularExpressions;
using Humanizer;

namespace LinqAn.Google.Generator.Core
{
    public static class ColumnExtensions
    {
        public static string ToClassName(this Column column)
        {
            var className = column.Id.Replace("ga:", "").Pascalize().Replace("ID", "Id");
            var match = Regex.Match(className, "^[0-9]+");
            if (!match.Success) return className;
            var number = match.ToString();
            var numberAsInt = Convert.ToInt32(number);
            var replacement = numberAsInt.ToWords().Dehumanize();
            className = className.Replace(number, replacement);
            return className;
        }
    }
}