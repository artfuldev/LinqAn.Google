namespace DotNetAnalytics.Google.Dimensions
{
	public class DFAActivityDimension: Dimension<string>
	{
		/// <summary>
		/// 	DCM Floodlight activity name associated with the floodlight conversion (premium only).
		/// </summary>
		public DFAActivityDimension(): base("DFA Activity","DCM Floodlight activity name associated with the floodlight conversion (premium only).",false,"ga:dcmFloodlightActivity")
		{
			
		}
	}
}

