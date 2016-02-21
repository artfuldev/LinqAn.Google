namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The language provided by the HTTP Request for the browser. Values are given as an ISO-639 code (e.g. en-gb for British English).
	/// </summary>
	public class Language: Dimension<string>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Language" />.
		/// </summary>
		public Language(): base("Language","The language provided by the HTTP Request for the browser. Values are given as an ISO-639 code (e.g. en-gb for British English).",true,"ga:language")
		{
			
		}
	}
}

