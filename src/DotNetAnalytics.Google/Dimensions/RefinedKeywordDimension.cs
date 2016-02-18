namespace DotNetAnalytics.Google.Dimensions
{
	public class RefinedKeywordDimension: Dimension<string>
	{
		/// <summary>
		/// 	Subsequent keyword search terms or strings entered by users after a given initial string search.
		/// </summary>
		public RefinedKeywordDimension(): base("Refined Keyword","Subsequent keyword search terms or strings entered by users after a given initial string search.",true,"ga:searchKeywordRefinement")
		{
			
		}
	}
}

