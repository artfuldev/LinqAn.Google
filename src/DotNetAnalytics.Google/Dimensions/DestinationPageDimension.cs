namespace DotNetAnalytics.Google.Dimensions
{
	/// <summary>
	/// 	The page the user immediately visited after performing an internal search on your site. (Usually the search results page).
	/// </summary>
	public class DestinationPageDimension: Dimension<string>
	{
		/// <summary>
	/// 	Instantiates a <seealso cref="DestinationPageDimension" />.
		/// </summary>
		public DestinationPageDimension(): base("Destination Page","The page the user immediately visited after performing an internal search on your site. (Usually the search results page).",false,"ga:searchDestinationPage")
		{
			
		}
	}
}

