namespace DotNetAnalytics.Google.Dimensions
{
	public class DFAFloodlightConfigurationIDDFAModelDimension: Dimension<string>
	{
		/// <summary>
		/// 	DCM Floodlight configuration ID of the last DCM event (impression or click within the DCM lookback window) associated with the Google Analytics session (premium only).
		/// </summary>
		public DFAFloodlightConfigurationIDDFAModelDimension(): base("DFA Floodlight Configuration ID (DFA Model)","DCM Floodlight configuration ID of the last DCM event (impression or click within the DCM lookback window) associated with the Google Analytics session (premium only).",false,"ga:dcmLastEventSpotId")
		{
			
		}
	}
}

