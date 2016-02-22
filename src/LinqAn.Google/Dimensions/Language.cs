using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The language provided by the HTTP Request for the browser. Values are given as an ISO-639 code (e.g. en-gb for British English).
	/// </summary>
	[Description("The language provided by the HTTP Request for the browser. Values are given as an ISO-639 code (e.g. en-gb for British English).")]
	public class Language: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Language" />.
		/// </summary>
		public Language(): base("Language",true,"ga:language")
		{
			
		}
	}
}

