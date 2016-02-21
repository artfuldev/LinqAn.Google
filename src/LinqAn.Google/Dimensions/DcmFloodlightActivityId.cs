namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	DCM Floodlight activity ID associated with the floodlight conversion (premium only).
	/// </summary>
	public class DcmFloodlightActivityId: Dimension<string>
	{
		/// <summary>
	/// 	Instantiates a <seealso cref="DcmFloodlightActivityId" />.
		/// </summary>
		public DcmFloodlightActivityId(): base("DFA Activity ID","DCM Floodlight activity ID associated with the floodlight conversion (premium only).",false,"ga:dcmFloodlightActivityId")
		{
			
		}
	}
}

