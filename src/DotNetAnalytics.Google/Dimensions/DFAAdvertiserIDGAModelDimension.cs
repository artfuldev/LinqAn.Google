namespace DotNetAnalytics.Google.Dimensions
{
	public class DFAAdvertiserIDGAModelDimension: Dimension<string>
	{
		/// <summary>
		/// 	DCM advertiser ID of the DCM click matching the Google Analytics session (premium only).
		/// </summary>
		public DFAAdvertiserIDGAModelDimension(): base("DFA Advertiser ID (GA Model)","DCM advertiser ID of the DCM click matching the Google Analytics session (premium only).",false,"ga:dcmClickAdvertiserId")
		{
			
		}
	}
}

