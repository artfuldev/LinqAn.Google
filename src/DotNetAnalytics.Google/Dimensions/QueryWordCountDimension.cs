namespace DotNetAnalytics.Google.Dimensions
{
	public class QueryWordCountDimension: Dimension<string>
	{
		/// <summary>
		/// 	The number of words in the search query.
		/// </summary>
		public QueryWordCountDimension(): base("Query Word Count","The number of words in the search query.",false,"ga:adQueryWordCount")
		{
			
		}
	}
}

