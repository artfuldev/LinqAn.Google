namespace DotNetAnalytics.Google.Dimensions
{
	public class DFAActivityGroupDimension: Dimension<string>
	{
		/// <summary>
		/// 	DCM Floodlight activity group name associated with the floodlight conversion (premium only).
		/// </summary>
		public DFAActivityGroupDimension(): base("DFA Activity Group","DCM Floodlight activity group name associated with the floodlight conversion (premium only).",false,"ga:dcmFloodlightActivityGroup")
		{
			
		}
	}
}

