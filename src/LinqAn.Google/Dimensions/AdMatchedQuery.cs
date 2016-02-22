namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The search queries that triggered impressions of your AdWords ads.
	/// </summary>
	public class AdMatchedQuery: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="AdMatchedQuery" />.
		/// </summary>
		public AdMatchedQuery(): base("Matched Search Query","The search queries that triggered impressions of your AdWords ads.",false,"ga:adMatchedQuery")
		{
			
		}
	}
}

