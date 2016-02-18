namespace DotNetAnalytics.Google.Dimensions
{
	public class DFAActivityGroupIDDimension: Dimension<string>
	{
		/// <summary>
		/// 	DCM Floodlight activity group ID associated with the floodlight conversion (premium only).
		/// </summary>
		public DFAActivityGroupIDDimension(): base("DFA Activity Group ID","DCM Floodlight activity group ID associated with the floodlight conversion (premium only).",false,"ga:dcmFloodlightActivityGroupId")
		{
			
		}
	}
}

