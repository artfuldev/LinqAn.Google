using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	A page that the user visited after performing an internal search on your site.
	/// </summary>
	[Description("A page that the user visited after performing an internal search on your site.")]
	public class SearchAfterDestinationPage: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="SearchAfterDestinationPage" />.
		/// </summary>
		public SearchAfterDestinationPage(): base("Search Destination Page",true,"ga:searchAfterDestinationPage")
		{
			
		}
	}
}

