namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The first page in a user's session, or landing page.
	/// </summary>
	public class LandingPagePath: Dimension<string>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="LandingPagePath" />.
		/// </summary>
		public LandingPagePath(): base("Landing Page","The first page in a user's session, or landing page.",true,"ga:landingPagePath")
		{
			
		}
	}
}

