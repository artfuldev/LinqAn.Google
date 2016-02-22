using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The page the user immediately visited after performing an internal search on your site. (Usually the search results page).
	/// </summary>
	[Description("The page the user immediately visited after performing an internal search on your site. (Usually the search results page).")]
	public class SearchDestinationPage: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="SearchDestinationPage" />.
		/// </summary>
		public SearchDestinationPage(): base("Destination Page",false,"ga:searchDestinationPage")
		{
			
		}
	}
}

