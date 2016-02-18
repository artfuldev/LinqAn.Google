namespace DotNetAnalytics.Google.Dimensions
{
	public class DFACampaignDFAModelDimension: Dimension<string>
	{
		/// <summary>
		/// 	DCM campaign name of the last DCM event (impression or click within the DCM lookback window) associated with the Google Analytics session (premium only).
		/// </summary>
		public DFACampaignDFAModelDimension(): base("DFA Campaign (DFA Model)","DCM campaign name of the last DCM event (impression or click within the DCM lookback window) associated with the Google Analytics session (premium only).",false,"ga:dcmLastEventCampaign")
		{
			
		}
	}
}

