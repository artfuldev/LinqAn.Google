namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	Subsequent keyword search terms or strings entered by users after a given initial string search.
	/// </summary>
	public class SearchKeywordRefinement: Dimension<string>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="SearchKeywordRefinement" />.
		/// </summary>
		public SearchKeywordRefinement(): base("Refined Keyword","Subsequent keyword search terms or strings entered by users after a given initial string search.",true,"ga:searchKeywordRefinement")
		{
			
		}
	}
}

