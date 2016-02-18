namespace DotNetAnalytics.Google.Dimensions
{
	/// <summary>
	/// 	Subsequent keyword search terms or strings entered by users after a given initial string search.
	/// </summary>
	public class RefinedKeywordDimension: Dimension<string>
	{
		/// <summary>
	/// 	Instantiates a <seealso cref="RefinedKeywordDimension" />.
		/// </summary>
		public RefinedKeywordDimension(): base("Refined Keyword","Subsequent keyword search terms or strings entered by users after a given initial string search.",true,"ga:searchKeywordRefinement")
		{
			
		}
	}
}

