namespace DotNetAnalytics.Google.Dimensions
{
	/// <summary>
	/// 	DCM Floodlight activity name associated with the floodlight conversion (premium only).
	/// </summary>
	public class DFAActivityDimension: Dimension<string>
	{
		/// <summary>
	/// 	Instantiates a <seealso cref="DFAActivityDimension" />.
		/// </summary>
		public DFAActivityDimension(): base("DFA Activity","DCM Floodlight activity name associated with the floodlight conversion (premium only).",false,"ga:dcmFloodlightActivity")
		{
			
		}
	}
}

