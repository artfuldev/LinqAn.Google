using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	DCM Floodlight configuration ID of the DCM click matching the Google Analytics session (premium only).
	/// </summary>
	[Description("DCM Floodlight configuration ID of the DCM click matching the Google Analytics session (premium only).")]
	public class DcmClickSpotId: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="DcmClickSpotId" />.
		/// </summary>
		public DcmClickSpotId(): base("DFA Floodlight Configuration ID (GA Model)",false,"ga:dcmClickSpotId")
		{
			
		}
	}
}

