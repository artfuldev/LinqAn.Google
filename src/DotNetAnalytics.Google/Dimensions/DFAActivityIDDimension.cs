namespace DotNetAnalytics.Google.Dimensions
{
	/// <summary>
	/// 	DCM Floodlight activity ID associated with the floodlight conversion (premium only).
	/// </summary>
	public class DFAActivityIDDimension: Dimension<string>
	{
		/// <summary>
	/// 	Instantiates a <seealso cref="DFAActivityIDDimension" />.
		/// </summary>
		public DFAActivityIDDimension(): base("DFA Activity ID","DCM Floodlight activity ID associated with the floodlight conversion (premium only).",false,"ga:dcmFloodlightActivityId")
		{
			
		}
	}
}

