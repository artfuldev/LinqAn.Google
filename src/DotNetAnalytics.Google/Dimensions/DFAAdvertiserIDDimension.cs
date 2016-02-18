namespace DotNetAnalytics.Google.Dimensions
{
	public class DFAAdvertiserIDDimension: Dimension<string>
	{
		/// <summary>
		/// 	DCM Floodlight advertiser ID associated with the floodlight conversion (premium only).
		/// </summary>
		public DFAAdvertiserIDDimension(): base("DFA Advertiser ID","DCM Floodlight advertiser ID associated with the floodlight conversion (premium only).",false,"ga:dcmFloodlightAdvertiserId")
		{
			
		}
	}
}

