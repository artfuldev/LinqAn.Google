using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	DCM campaign ID of the last DCM event (impression or click within the DCM lookback window) associated with the Google Analytics session (premium only).
	/// </summary>
	[Description("DCM campaign ID of the last DCM event (impression or click within the DCM lookback window) associated with the Google Analytics session (premium only).")]
	public class DcmLastEventCampaignId: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="DcmLastEventCampaignId" />.
		/// </summary>
		public DcmLastEventCampaignId(): base("DFA Campaign ID (DFA Model)",false,"ga:dcmLastEventCampaignId")
		{
			
		}
	}
}

