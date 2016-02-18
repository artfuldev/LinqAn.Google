namespace DotNetAnalytics.Google.Dimensions
{
	public class DFAActivityIDDimension: Dimension<string>
	{
		/// <summary>
		/// 	DCM Floodlight activity ID associated with the floodlight conversion (premium only).
		/// </summary>
		public DFAActivityIDDimension(): base("DFA Activity ID","DCM Floodlight activity ID associated with the floodlight conversion (premium only).",false,"ga:dcmFloodlightActivityId")
		{
			
		}
	}
}

