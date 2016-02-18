namespace DotNetAnalytics.Google.Dimensions
{
	public class DFAAdvertiserIDDFAModelDimension: Dimension<string>
	{
		/// <summary>
		/// 	DCM advertiser ID of the last DCM event (impression or click within the DCM lookback window) associated with the Google Analytics session (premium only).
		/// </summary>
		public DFAAdvertiserIDDFAModelDimension(): base("DFA Advertiser ID (DFA Model)","DCM advertiser ID of the last DCM event (impression or click within the DCM lookback window) associated with the Google Analytics session (premium only).",false,"ga:dcmLastEventAdvertiserId")
		{
			
		}
	}
}

