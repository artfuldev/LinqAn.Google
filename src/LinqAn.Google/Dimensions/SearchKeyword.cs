using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	Search terms used by users within your property.
	/// </summary>
	[Description("Search terms used by users within your property.")]
	public class SearchKeyword: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="SearchKeyword" />.
		/// </summary>
		public SearchKeyword(): base("Search Term",true,"ga:searchKeyword")
		{
			
		}
	}
}

