using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	For a social data hub activity, this value represents the type of social action and the social network where the activity originated.
	/// </summary>
	[Description("For a social data hub activity, this value represents the type of social action and the social network where the activity originated.")]
	public class SocialActivityNetworkAction: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="SocialActivityNetworkAction" />.
		/// </summary>
		public SocialActivityNetworkAction(): base("Social Network and Action",false,"ga:socialActivityNetworkAction")
		{
			
		}
	}
}

