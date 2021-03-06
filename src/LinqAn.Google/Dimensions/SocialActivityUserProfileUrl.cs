using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	For a social data hub activity, this value represents the URL of the associated user's social network profile.
	/// </summary>
	[Description("For a social data hub activity, this value represents the URL of the associated user's social network profile.")]
	public class SocialActivityUserProfileUrl: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="SocialActivityUserProfileUrl" />.
		/// </summary>
		public SocialActivityUserProfileUrl(): base("User Profile URL",false,"ga:socialActivityUserProfileUrl")
		{
			
		}
	}
}

