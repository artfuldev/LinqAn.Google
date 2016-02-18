namespace DotNetAnalytics.Google.Dimensions
{
	public class DFAAttributionTypeDFAModelDimension: Dimension<string>
	{
		/// <summary>
		/// 	There are two possible values: ClickThrough and ViewThrough. If the last DCM event associated with the Google Analytics session was a click, then the value will be ClickThrough. If the last DCM event associated with the Google Analytics session was an ad impression, then the value will be ViewThrough (premium only).
		/// </summary>
		public DFAAttributionTypeDFAModelDimension(): base("DFA Attribution Type (DFA Model)","There are two possible values: ClickThrough and ViewThrough. If the last DCM event associated with the Google Analytics session was a click, then the value will be ClickThrough. If the last DCM event associated with the Google Analytics session was an ad impression, then the value will be ViewThrough (premium only).",false,"ga:dcmLastEventAttributionType")
		{
			
		}
	}
}

