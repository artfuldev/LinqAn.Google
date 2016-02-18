namespace DotNetAnalytics.Google.Dimensions
{
	public class MatchedSearchQueryDimension: Dimension<string>
	{
		/// <summary>
		/// 	The search queries that triggered impressions of your AdWords ads.
		/// </summary>
		public MatchedSearchQueryDimension(): base("Matched Search Query","The search queries that triggered impressions of your AdWords ads.",false,"ga:adMatchedQuery")
		{
			
		}
	}
}

