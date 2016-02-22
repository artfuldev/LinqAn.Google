using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	DCM Floodlight activity ID associated with the floodlight conversion (premium only).
	/// </summary>
	[Description("DCM Floodlight activity ID associated with the floodlight conversion (premium only).")]
	public class DcmFloodlightActivityId: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="DcmFloodlightActivityId" />.
		/// </summary>
		public DcmFloodlightActivityId(): base("DFA Activity ID",false,"ga:dcmFloodlightActivityId")
		{
			
		}
	}
}

