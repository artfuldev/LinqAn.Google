namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	DCM campaign name of the last DCM event (impression or click within the DCM lookback window) associated with the Google Analytics session (premium only).
	/// </summary>
	public class DcmLastEventCampaign: Dimension<string>
	{
		/// <summary>
	/// 	Instantiates a <seealso cref="DcmLastEventCampaign" />.
		/// </summary>
		public DcmLastEventCampaign(): base("DFA Campaign (DFA Model)","DCM campaign name of the last DCM event (impression or click within the DCM lookback window) associated with the Google Analytics session (premium only).",false,"ga:dcmLastEventCampaign")
		{
			
		}
	}
}

