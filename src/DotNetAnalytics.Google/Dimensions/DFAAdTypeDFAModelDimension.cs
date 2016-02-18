namespace DotNetAnalytics.Google.Dimensions
{
	public class DFAAdTypeDFAModelDimension: Dimension<string>
	{
		/// <summary>
		/// 	DCM ad type name of the last DCM event (impression or click within the DCM lookback window) associated with the Google Analytics session (premium only).
		/// </summary>
		public DFAAdTypeDFAModelDimension(): base("DFA Ad Type (DFA Model)","DCM ad type name of the last DCM event (impression or click within the DCM lookback window) associated with the Google Analytics session (premium only).",false,"ga:dcmLastEventAdType")
		{
			
		}
	}
}

