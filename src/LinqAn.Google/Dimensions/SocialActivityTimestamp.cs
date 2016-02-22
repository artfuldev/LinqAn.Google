using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	For a social data hub activity, this value represents when the social activity occurred on the social network.
	/// </summary>
	[Description("For a social data hub activity, this value represents when the social activity occurred on the social network.")]
	public class SocialActivityTimestamp: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="SocialActivityTimestamp" />.
		/// </summary>
		public SocialActivityTimestamp(): base("Social Activity Timestamp",false,"ga:socialActivityTimestamp")
		{
			
		}
	}
}

