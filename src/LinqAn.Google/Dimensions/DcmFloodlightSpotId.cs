using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	DCM Floodlight configuration ID associated with the floodlight conversion (premium only).
	/// </summary>
	[Description("DCM Floodlight configuration ID associated with the floodlight conversion (premium only).")]
	public class DcmFloodlightSpotId: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="DcmFloodlightSpotId" />.
		/// </summary>
		public DcmFloodlightSpotId(): base("DFA Floodlight Configuration ID",false,"ga:dcmFloodlightSpotId")
		{
			
		}
	}
}

