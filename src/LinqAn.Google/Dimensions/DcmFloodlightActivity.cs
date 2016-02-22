using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	DCM Floodlight activity name associated with the floodlight conversion (premium only).
	/// </summary>
	[Description("DCM Floodlight activity name associated with the floodlight conversion (premium only).")]
	public class DcmFloodlightActivity: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="DcmFloodlightActivity" />.
		/// </summary>
		public DcmFloodlightActivity(): base("DFA Activity",false,"ga:dcmFloodlightActivity")
		{
			
		}
	}
}

