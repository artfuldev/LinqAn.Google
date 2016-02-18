namespace DotNetAnalytics.Google.Dimensions
{
	public class DFAFloodlightConfigurationIDDimension: Dimension<string>
	{
		/// <summary>
		/// 	DCM Floodlight configuration ID associated with the floodlight conversion (premium only).
		/// </summary>
		public DFAFloodlightConfigurationIDDimension(): base("DFA Floodlight Configuration ID","DCM Floodlight configuration ID associated with the floodlight conversion (premium only).",false,"ga:dcmFloodlightSpotId")
		{
			
		}
	}
}

