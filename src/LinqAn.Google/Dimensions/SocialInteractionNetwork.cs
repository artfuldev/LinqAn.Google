using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	For social interactions, a value representing the social network being tracked.
	/// </summary>
	[Description("For social interactions, a value representing the social network being tracked.")]
	public class SocialInteractionNetwork: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="SocialInteractionNetwork" />.
		/// </summary>
		public SocialInteractionNetwork(): base("Social Network",false,"ga:socialInteractionNetwork")
		{
			
		}
	}
}

