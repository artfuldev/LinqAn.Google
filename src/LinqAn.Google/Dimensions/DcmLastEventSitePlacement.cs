using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	DCM site placement name of the last DCM event (impression or click within the DCM lookback window) associated with the Google Analytics session (premium only).
	/// </summary>
	[Description("DCM site placement name of the last DCM event (impression or click within the DCM lookback window) associated with the Google Analytics session (premium only).")]
	public class DcmLastEventSitePlacement: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="DcmLastEventSitePlacement" />.
		/// </summary>
		public DcmLastEventSitePlacement(): base("DFA Placement (DFA Model)",false,"ga:dcmLastEventSitePlacement")
		{
			
		}
	}
}

