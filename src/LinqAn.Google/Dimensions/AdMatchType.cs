using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The match types applied for the search term the user had input(Phrase, Exact, Broad, etc.). Ads on the content network are identified as "Content network". Details: https://support.google.com/adwords/answer/2472708?hl=en
	/// </summary>
	[Description("The match types applied for the search term the user had input(Phrase, Exact, Broad, etc.). Ads on the content network are identified as \"Content network\". Details: https://support.google.com/adwords/answer/2472708?hl=en")]
	public class AdMatchType: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="AdMatchType" />.
		/// </summary>
		public AdMatchType(): base("Query Match Type",false,"ga:adMatchType")
		{
			
		}
	}
}

