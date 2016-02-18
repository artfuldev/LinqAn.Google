namespace DotNetAnalytics.Google.Dimensions
{
	public class DFACreativeDFAModelDimension: Dimension<string>
	{
		/// <summary>
		/// 	DCM creative name of the last DCM event (impression or click within the DCM lookback window) associated with the Google Analytics session (premium only).
		/// </summary>
		public DFACreativeDFAModelDimension(): base("DFA Creative (DFA Model)","DCM creative name of the last DCM event (impression or click within the DCM lookback window) associated with the Google Analytics session (premium only).",false,"ga:dcmLastEventCreative")
		{
			
		}
	}
}

