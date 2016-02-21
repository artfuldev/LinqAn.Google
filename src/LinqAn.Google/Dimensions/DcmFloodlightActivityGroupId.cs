namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	DCM Floodlight activity group ID associated with the floodlight conversion (premium only).
	/// </summary>
	public class DcmFloodlightActivityGroupId: Dimension<string>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="DcmFloodlightActivityGroupId" />.
		/// </summary>
		public DcmFloodlightActivityGroupId(): base("DFA Activity Group ID","DCM Floodlight activity group ID associated with the floodlight conversion (premium only).",false,"ga:dcmFloodlightActivityGroupId")
		{
			
		}
	}
}

