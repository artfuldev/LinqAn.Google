namespace DotNetAnalytics.Google.Dimensions
{
	public class DFAActivityAndGroupDimension: Dimension<string>
	{
		/// <summary>
		/// 	DCM Floodlight activity name and group name associated with the floodlight conversion (premium only).
		/// </summary>
		public DFAActivityAndGroupDimension(): base("DFA Activity and Group","DCM Floodlight activity name and group name associated with the floodlight conversion (premium only).",false,"ga:dcmFloodlightActivityAndGroup")
		{
			
		}
	}
}

