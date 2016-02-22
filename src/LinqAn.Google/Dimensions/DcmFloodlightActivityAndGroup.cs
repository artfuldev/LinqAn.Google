using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	DCM Floodlight activity name and group name associated with the floodlight conversion (premium only).
	/// </summary>
	[Description("DCM Floodlight activity name and group name associated with the floodlight conversion (premium only).")]
	public class DcmFloodlightActivityAndGroup: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="DcmFloodlightActivityAndGroup" />.
		/// </summary>
		public DcmFloodlightActivityAndGroup(): base("DFA Activity and Group",false,"ga:dcmFloodlightActivityAndGroup")
		{
			
		}
	}
}

