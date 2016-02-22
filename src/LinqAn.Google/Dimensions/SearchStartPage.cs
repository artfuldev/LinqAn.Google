using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	A page where the user initiated an internal search.
	/// </summary>
	[Description("A page where the user initiated an internal search.")]
	public class SearchStartPage: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="SearchStartPage" />.
		/// </summary>
		public SearchStartPage(): base("Start Page",false,"ga:searchStartPage")
		{
			
		}
	}
}

