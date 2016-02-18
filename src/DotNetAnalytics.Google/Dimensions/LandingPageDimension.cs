namespace DotNetAnalytics.Google.Dimensions
{
	/// <summary>
	/// 	The first page in a user's session, or landing page.
	/// </summary>
	public class LandingPageDimension: Dimension<string>
	{
		/// <summary>
	/// 	Instantiates a <seealso cref="LandingPageDimension" />.
		/// </summary>
		public LandingPageDimension(): base("Landing Page","The first page in a user's session, or landing page.",true,"ga:landingPagePath")
		{
			
		}
	}
}

