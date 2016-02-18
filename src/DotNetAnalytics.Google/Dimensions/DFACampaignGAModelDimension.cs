namespace DotNetAnalytics.Google.Dimensions
{
	public class DFACampaignGAModelDimension: Dimension<string>
	{
		/// <summary>
		/// 	DCM campaign name of the DCM click matching the Google Analytics session (premium only).
		/// </summary>
		public DFACampaignGAModelDimension(): base("DFA Campaign (GA Model)","DCM campaign name of the DCM click matching the Google Analytics session (premium only).",false,"ga:dcmClickCampaign")
		{
			
		}
	}
}

