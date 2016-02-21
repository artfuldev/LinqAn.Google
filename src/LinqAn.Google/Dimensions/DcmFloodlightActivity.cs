namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	DCM Floodlight activity name associated with the floodlight conversion (premium only).
	/// </summary>
	public class DcmFloodlightActivity: Dimension<string>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="DcmFloodlightActivity" />.
		/// </summary>
		public DcmFloodlightActivity(): base("DFA Activity","DCM Floodlight activity name associated with the floodlight conversion (premium only).",false,"ga:dcmFloodlightActivity")
		{
			
		}
	}
}

