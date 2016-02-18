namespace DotNetAnalytics.Google.Dimensions
{
	/// <summary>
	/// 	The search queries that triggered impressions of your AdWords ads.
	/// </summary>
	public class MatchedSearchQueryDimension: Dimension<string>
	{
		/// <summary>
	/// 	Instantiates a <seealso cref="MatchedSearchQueryDimension" />.
		/// </summary>
		public MatchedSearchQueryDimension(): base("Matched Search Query","The search queries that triggered impressions of your AdWords ads.",false,"ga:adMatchedQuery")
		{
			
		}
	}
}

