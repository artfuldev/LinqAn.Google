using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	When using manual campaign tracking, the value of the utm_id campaign tracking parameter.
	/// </summary>
	[Description("When using manual campaign tracking, the value of the utm_id campaign tracking parameter.")]
	public class CampaignCode: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="CampaignCode" />.
		/// </summary>
		public CampaignCode(): base("Campaign Code",false,"ga:campaignCode")
		{
			
		}
	}
}

