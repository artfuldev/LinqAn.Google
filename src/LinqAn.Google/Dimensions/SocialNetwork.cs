using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	Name of the social network. This can be related to the referring social network for traffic sources, or to the social network for social data hub activities. E.g. Google+, Blogger, etc.
	/// </summary>
	[Description("Name of the social network. This can be related to the referring social network for traffic sources, or to the social network for social data hub activities. E.g. Google+, Blogger, etc.")]
	public class SocialNetwork: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="SocialNetwork" />.
		/// </summary>
		public SocialNetwork(): base("Social Network",false,"ga:socialNetwork")
		{
			
		}
	}
}

