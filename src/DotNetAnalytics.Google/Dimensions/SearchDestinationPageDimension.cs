namespace DotNetAnalytics.Google.Dimensions
{
	public class SearchDestinationPageDimension: Dimension<string>
	{
		/// <summary>
		/// 	A page that the user visited after performing an internal search on your site.
		/// </summary>
		public SearchDestinationPageDimension(): base("Search Destination Page","A page that the user visited after performing an internal search on your site.",true,"ga:searchAfterDestinationPage")
		{
			
		}
	}
}

