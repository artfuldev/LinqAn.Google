using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	For a social data hub activity, this value represents the URL of the photo associated with the user's social network profile.
	/// </summary>
	[Description("For a social data hub activity, this value represents the URL of the photo associated with the user's social network profile.")]
	public class SocialActivityUserPhotoUrl: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="SocialActivityUserPhotoUrl" />.
		/// </summary>
		public SocialActivityUserPhotoUrl(): base("User Photo URL",false,"ga:socialActivityUserPhotoUrl")
		{
			
		}
	}
}

