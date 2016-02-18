namespace DotNetAnalytics.Google.Dimensions
{
	public class DFAPlacementDFAModelDimension: Dimension<string>
	{
		/// <summary>
		/// 	DCM site placement name of the last DCM event (impression or click within the DCM lookback window) associated with the Google Analytics session (premium only).
		/// </summary>
		public DFAPlacementDFAModelDimension(): base("DFA Placement (DFA Model)","DCM site placement name of the last DCM event (impression or click within the DCM lookback window) associated with the Google Analytics session (premium only).",false,"ga:dcmLastEventSitePlacement")
		{
			
		}
	}
}

