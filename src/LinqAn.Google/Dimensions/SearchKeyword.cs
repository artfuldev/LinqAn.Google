namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	Search terms used by users within your property.
	/// </summary>
	public class SearchKeyword: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="SearchKeyword" />.
		/// </summary>
		public SearchKeyword(): base("Search Term","Search terms used by users within your property.",true,"ga:searchKeyword")
		{
			
		}
	}
}

