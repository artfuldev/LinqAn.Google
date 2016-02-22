using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	DCM Floodlight activity group name associated with the floodlight conversion (premium only).
	/// </summary>
	[Description("DCM Floodlight activity group name associated with the floodlight conversion (premium only).")]
	public class DcmFloodlightActivityGroup: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="DcmFloodlightActivityGroup" />.
		/// </summary>
		public DcmFloodlightActivityGroup(): base("DFA Activity Group",false,"ga:dcmFloodlightActivityGroup")
		{
			
		}
	}
}

