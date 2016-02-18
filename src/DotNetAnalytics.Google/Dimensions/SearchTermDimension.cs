namespace DotNetAnalytics.Google.Dimensions
{
	/// <summary>
	/// 	Search terms used by users within your property.
	/// </summary>
	public class SearchTermDimension: Dimension<string>
	{
		/// <summary>
	/// 	Instantiates a <seealso cref="SearchTermDimension" />.
		/// </summary>
		public SearchTermDimension(): base("Search Term","Search terms used by users within your property.",true,"ga:searchKeyword")
		{
			
		}
	}
}

