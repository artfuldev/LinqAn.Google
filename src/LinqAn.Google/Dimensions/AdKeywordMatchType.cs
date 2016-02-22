using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The match types applied to your keywords (Phrase, Exact, Broad). Details: https://support.google.com/adwords/answer/2472708?hl=en
	/// </summary>
	[Description("The match types applied to your keywords (Phrase, Exact, Broad). Details: https://support.google.com/adwords/answer/2472708?hl=en")]
	public class AdKeywordMatchType: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="AdKeywordMatchType" />.
		/// </summary>
		public AdKeywordMatchType(): base("Keyword Match Type",false,"ga:adKeywordMatchType")
		{
			
		}
	}
}

