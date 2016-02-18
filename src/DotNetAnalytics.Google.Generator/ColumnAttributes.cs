using System;
using System.Collections.Generic;
using System.Security.AccessControl;

namespace DotNetAnalytics.Google.Generator
{
	public class ColumnAttributes
	{
	    private static readonly IDictionary<string, Type> TypeMapping = new Dictionary<string, Type>()
	    {
	        {"STRING", typeof (string)},
	        {"INTEGER", typeof (int)},
	        {"PERCENT", typeof (float)},
	        {"TIME", typeof (TimeSpan)},
	        {"CURRENCY", typeof (decimal)},
	        {"FLOAT", typeof (float)}
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
	    public Type DestinationType
	        => string.IsNullOrWhiteSpace(Type) ? null : TypeMapping.ContainsKey(Type) ? TypeMapping[Type] : null;
	    public string Type { get; set; }
        public string MinTemplateIndex { get; set; }
        public string MaxTemplateIndex { get; set; }
        public string PremiumMinTemplateIndex { get; set; }
        public string PremiumMaxTemplateIndex { get; set; }
	    public bool IsTemplated => !string.IsNullOrWhiteSpace(MinTemplateIndex);
	}
}