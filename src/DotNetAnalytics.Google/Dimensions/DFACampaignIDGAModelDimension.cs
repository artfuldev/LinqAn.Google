namespace DotNetAnalytics.Google.Dimensions
{
	public class DFACampaignIDGAModelDimension: Dimension<string>
	{
		/// <summary>
		/// 	DCM campaign ID of the DCM click matching the Google Analytics session (premium only).
		/// </summary>
		public DFACampaignIDGAModelDimension(): base("DFA Campaign ID (GA Model)","DCM campaign ID of the DCM click matching the Google Analytics session (premium only).",false,"ga:dcmClickCampaignId")
		{
			
		}
	}
}

