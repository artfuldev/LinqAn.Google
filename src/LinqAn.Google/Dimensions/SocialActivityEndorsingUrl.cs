using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	For a social data hub activity, this value represents the URL of the social activity (e.g. the Google+ post URL, the blog comment URL, etc.)
	/// </summary>
	[Description("For a social data hub activity, this value represents the URL of the social activity (e.g. the Google+ post URL, the blog comment URL, etc.)")]
	public class SocialActivityEndorsingUrl: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="SocialActivityEndorsingUrl" />.
		/// </summary>
		public SocialActivityEndorsingUrl(): base("Endorsing URL",false,"ga:socialActivityEndorsingUrl")
		{
			
		}
	}
}

