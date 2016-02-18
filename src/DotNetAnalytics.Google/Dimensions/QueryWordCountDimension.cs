namespace DotNetAnalytics.Google.Dimensions
{
	/// <summary>
	/// 	The number of words in the search query.
	/// </summary>
	public class QueryWordCountDimension: Dimension<string>
	{
		/// <summary>
	/// 	Instantiates a <seealso cref="QueryWordCountDimension" />.
		/// </summary>
		public QueryWordCountDimension(): base("Query Word Count","The number of words in the search query.",false,"ga:adQueryWordCount")
		{
			
		}
	}
}

