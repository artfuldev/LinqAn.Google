using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	Content group of a user's landing page.
	/// </summary>
	[Description("Content group of a user's landing page.")]
	public class LandingContentGroup1: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="LandingContentGroup1" />.
		/// </summary>
		public LandingContentGroup1(): base("Landing Page Group 1",true,"ga:landingContentGroup1")
		{
			
		}
	}
}

