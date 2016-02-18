namespace DotNetAnalytics.Google.Dimensions
{
	public class DFACampaignIDDFAModelDimension: Dimension<string>
	{
		/// <summary>
		/// 	DCM campaign ID of the last DCM event (impression or click within the DCM lookback window) associated with the Google Analytics session (premium only).
		/// </summary>
		public DFACampaignIDDFAModelDimension(): base("DFA Campaign ID (DFA Model)","DCM campaign ID of the last DCM event (impression or click within the DCM lookback window) associated with the Google Analytics session (premium only).",false,"ga:dcmLastEventCampaignId")
		{
			
		}
	}
}

