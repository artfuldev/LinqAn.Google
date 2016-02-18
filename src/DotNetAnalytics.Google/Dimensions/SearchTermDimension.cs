namespace DotNetAnalytics.Google.Dimensions
{
	public class SearchTermDimension: Dimension<string>
	{
		/// <summary>
		/// 	Search terms used by users within your property.
		/// </summary>
		public SearchTermDimension(): base("Search Term","Search terms used by users within your property.",true,"ga:searchKeyword")
		{
			
		}
	}
}

