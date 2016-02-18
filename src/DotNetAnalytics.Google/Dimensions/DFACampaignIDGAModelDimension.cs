namespace DotNetAnalytics.Google.Dimensions
{
	/// <summary>
	/// 	DCM campaign ID of the DCM click matching the Google Analytics session (premium only).
	/// </summary>
	public class DFACampaignIDGAModelDimension: Dimension<string>
	{
		/// <summary>
	/// 	Instantiates a <seealso cref="DFACampaignIDGAModelDimension" />.
		/// </summary>
		public DFACampaignIDGAModelDimension(): base("DFA Campaign ID (GA Model)","DCM campaign ID of the DCM click matching the Google Analytics session (premium only).",false,"ga:dcmClickCampaignId")
		{
			
		}
	}
}

