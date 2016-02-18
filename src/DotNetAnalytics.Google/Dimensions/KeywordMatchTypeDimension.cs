namespace DotNetAnalytics.Google.Dimensions
{
	/// <summary>
	/// 	The match types applied to your keywords (Phrase, Exact, Broad). Details: https://support.google.com/adwords/answer/2472708?hl=en
	/// </summary>
	public class KeywordMatchTypeDimension: Dimension<string>
	{
		/// <summary>
	/// 	Instantiates a <seealso cref="KeywordMatchTypeDimension" />.
		/// </summary>
		public KeywordMatchTypeDimension(): base("Keyword Match Type","The match types applied to your keywords (Phrase, Exact, Broad). Details: https://support.google.com/adwords/answer/2472708?hl=en",false,"ga:adKeywordMatchType")
		{
			
		}
	}
}

