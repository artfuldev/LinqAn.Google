using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	DCM site placement ID of the last DCM event (impression or click within the DCM lookback window) associated with the Google Analytics session (premium only).
	/// </summary>
	[Description("DCM site placement ID of the last DCM event (impression or click within the DCM lookback window) associated with the Google Analytics session (premium only).")]
	public class DcmLastEventSitePlacementId: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="DcmLastEventSitePlacementId" />.
		/// </summary>
		public DcmLastEventSitePlacementId(): base("DFA Placement ID (DFA Model)",false,"ga:dcmLastEventSitePlacementId")
		{
			
		}
	}
}

