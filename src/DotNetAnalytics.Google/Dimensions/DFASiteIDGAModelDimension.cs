namespace DotNetAnalytics.Google.Dimensions
{
	public class DFASiteIDGAModelDimension: Dimension<string>
	{
		/// <summary>
		/// 	DCM site ID where the DCM creative was shown and clicked on for the DCM click matching the Google Analytics session (premium only).
		/// </summary>
		public DFASiteIDGAModelDimension(): base("DFA Site ID (GA Model)","DCM site ID where the DCM creative was shown and clicked on for the DCM click matching the Google Analytics session (premium only).",false,"ga:dcmClickSiteId")
		{
			
		}
	}
}

