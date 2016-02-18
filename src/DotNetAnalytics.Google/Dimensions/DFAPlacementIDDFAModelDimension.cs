namespace DotNetAnalytics.Google.Dimensions
{
	public class DFAPlacementIDDFAModelDimension: Dimension<string>
	{
		/// <summary>
		/// 	DCM site placement ID of the last DCM event (impression or click within the DCM lookback window) associated with the Google Analytics session (premium only).
		/// </summary>
		public DFAPlacementIDDFAModelDimension(): base("DFA Placement ID (DFA Model)","DCM site placement ID of the last DCM event (impression or click within the DCM lookback window) associated with the Google Analytics session (premium only).",false,"ga:dcmLastEventSitePlacementId")
		{
			
		}
	}
}

