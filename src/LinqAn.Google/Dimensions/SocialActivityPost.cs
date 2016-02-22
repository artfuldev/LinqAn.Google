using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	For a social data hub activity, this value represents the content of the social activity posted by the social network user (e.g. The message content of a Google+ post)
	/// </summary>
	[Description("For a social data hub activity, this value represents the content of the social activity posted by the social network user (e.g. The message content of a Google+ post)")]
	public class SocialActivityPost: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="SocialActivityPost" />.
		/// </summary>
		public SocialActivityPost(): base("Social Activity Post",false,"ga:socialActivityPost")
		{
			
		}
	}
}

