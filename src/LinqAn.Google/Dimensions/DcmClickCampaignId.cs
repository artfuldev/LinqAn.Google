using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	DCM campaign ID of the DCM click matching the Google Analytics session (premium only).
	/// </summary>
	[Description("DCM campaign ID of the DCM click matching the Google Analytics session (premium only).")]
	public class DcmClickCampaignId: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="DcmClickCampaignId" />.
		/// </summary>
		public DcmClickCampaignId(): base("DFA Campaign ID (GA Model)",false,"ga:dcmClickCampaignId")
		{
			
		}
	}
}

