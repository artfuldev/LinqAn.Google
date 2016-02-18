namespace DotNetAnalytics.Google.Dimensions
{
	public class LanguageDimension: Dimension<string>
	{
		/// <summary>
		/// 	The language provided by the HTTP Request for the browser. Values are given as an ISO-639 code (e.g. en-gb for British English).
		/// </summary>
		public LanguageDimension(): base("Language","The language provided by the HTTP Request for the browser. Values are given as an ISO-639 code (e.g. en-gb for British English).",true,"ga:language")
		{
			
		}
	}
}

