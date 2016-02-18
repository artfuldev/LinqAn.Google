namespace DotNetAnalytics.Google.Dimensions
{
	public class StartPageDimension: Dimension<string>
	{
		/// <summary>
		/// 	A page where the user initiated an internal search.
		/// </summary>
		public StartPageDimension(): base("Start Page","A page where the user initiated an internal search.",false,"ga:searchStartPage")
		{
			
		}
	}
}

