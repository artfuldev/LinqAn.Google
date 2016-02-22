using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The first page in a user's session, or landing page.
	/// </summary>
	[Description("The first page in a user's session, or landing page.")]
	public class LandingPagePath: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="LandingPagePath" />.
		/// </summary>
		public LandingPagePath(): base("Landing Page",true,"ga:landingPagePath")
		{
			
		}
	}
}

