using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	DCM Floodlight activity group ID associated with the floodlight conversion (premium only).
	/// </summary>
	[Description("DCM Floodlight activity group ID associated with the floodlight conversion (premium only).")]
	public class DcmFloodlightActivityGroupId: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="DcmFloodlightActivityGroupId" />.
		/// </summary>
		public DcmFloodlightActivityGroupId(): base("DFA Activity Group ID",false,"ga:dcmFloodlightActivityGroupId")
		{
			
		}
	}
}

