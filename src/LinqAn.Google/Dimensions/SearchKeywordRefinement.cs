using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	Subsequent keyword search terms or strings entered by users after a given initial string search.
	/// </summary>
	[Description("Subsequent keyword search terms or strings entered by users after a given initial string search.")]
	public class SearchKeywordRefinement: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="SearchKeywordRefinement" />.
		/// </summary>
		public SearchKeywordRefinement(): base("Refined Keyword",true,"ga:searchKeywordRefinement")
		{
			
		}
	}
}

