using System.Collections.Generic;

namespace LinqAn.Google.Generator.Core
{
	public class ColumnAttributes
	{
		private static readonly IDictionary<string, string> TypeMapping = new Dictionary<string, string>()
		{
			{"STRING", "string"},
			{"INTEGER", "int"},
			{"PERCENT", "float"},
			{"TIME", "TimeSpan"},
			{"CURRENCY", "decimal"},
			{"FLOAT", "float"}
		};

		public string ReplacedBy { get; set; }
		public string DataType { get; set; }
		public string Group { get; set; }
		public string Status { get; set; }
		public string UiName { get; set; }
		public string Description { get; set; }
		public string Calculation { get; set; }
		public string AllowedInSegments { get; set; }
		public bool IsDeprecated => Status == "DEPRECATED";
		public bool IsAllowedInSegments => AllowedInSegments == "true";
		public string DestinationTypeName
			=> string.IsNullOrWhiteSpace(DataType) ? null : TypeMapping.ContainsKey(DataType) ? TypeMapping[DataType] : null;
		public string Type { get; set; }
		public string MinTemplateIndex { get; set; }
		public string MaxTemplateIndex { get; set; }
		public string PremiumMinTemplateIndex { get; set; }
		public string PremiumMaxTemplateIndex { get; set; }
		public bool IsTemplated => !string.IsNullOrWhiteSpace(MinTemplateIndex);
	}
}