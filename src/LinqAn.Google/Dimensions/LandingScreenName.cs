using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The name of the first screen viewed.
	/// </summary>
	[Description("The name of the first screen viewed.")]
	public class LandingScreenName: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="LandingScreenName" />.
		/// </summary>
		public LandingScreenName(): base("Landing Screen",true,"ga:landingScreenName")
		{
			
		}
	}
}

