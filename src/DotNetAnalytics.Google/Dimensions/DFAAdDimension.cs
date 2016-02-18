namespace DotNetAnalytics.Google.Dimensions
{
	public class DFAAdDimension: Dimension<string>
	{
		/// <summary>
		/// 	DCM ad name of the last DCM event (impression or click within the DCM lookback window) associated with the Google Analytics session (premium only).
		/// </summary>
		public DFAAdDimension(): base("DFA Ad","DCM ad name of the last DCM event (impression or click within the DCM lookback window) associated with the Google Analytics session (premium only).",false,"ga:dcmLastEventAd")
		{
			
		}
	}
}

