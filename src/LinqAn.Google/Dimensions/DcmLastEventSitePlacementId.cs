namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	DCM site placement ID of the last DCM event (impression or click within the DCM lookback window) associated with the Google Analytics session (premium only).
	/// </summary>
	public class DcmLastEventSitePlacementId: Dimension<string>
	{
		/// <summary>
	/// 	Instantiates a <seealso cref="DcmLastEventSitePlacementId" />.
		/// </summary>
		public DcmLastEventSitePlacementId(): base("DFA Placement ID (DFA Model)","DCM site placement ID of the last DCM event (impression or click within the DCM lookback window) associated with the Google Analytics session (premium only).",false,"ga:dcmLastEventSitePlacementId")
		{
			
		}
	}
}

