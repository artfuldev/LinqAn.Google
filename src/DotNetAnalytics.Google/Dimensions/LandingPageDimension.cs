namespace DotNetAnalytics.Google.Dimensions
{
	public class LandingPageDimension: Dimension<string>
	{
		/// <summary>
		/// 	The first page in a user's session, or landing page.
		/// </summary>
		public LandingPageDimension(): base("Landing Page","The first page in a user's session, or landing page.",true,"ga:landingPagePath")
		{
			
		}
	}
}

