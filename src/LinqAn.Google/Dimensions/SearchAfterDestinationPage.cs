namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	A page that the user visited after performing an internal search on your site.
	/// </summary>
	public class SearchAfterDestinationPage: Dimension<string>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="SearchAfterDestinationPage" />.
		/// </summary>
		public SearchAfterDestinationPage(): base("Search Destination Page","A page that the user visited after performing an internal search on your site.",true,"ga:searchAfterDestinationPage")
		{
			
		}
	}
}

