using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	Engagement type. Possible values are "Socially Engaged" or "Not Socially Engaged".
	/// </summary>
	[Description("Engagement type. Possible values are \"Socially Engaged\" or \"Not Socially Engaged\".")]
	public class SocialEngagementType: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="SocialEngagementType" />.
		/// </summary>
		public SocialEngagementType(): base("Social Type",false,"ga:socialEngagementType")
		{
			
		}
	}
}

