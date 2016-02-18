namespace DotNetAnalytics.Google.Dimensions
{
	public class DFAAdIDGAModelDimension: Dimension<string>
	{
		/// <summary>
		/// 	DCM ad ID of the DCM click matching the Google Analytics session (premium only).
		/// </summary>
		public DFAAdIDGAModelDimension(): base("DFA Ad ID (GA Model)","DCM ad ID of the DCM click matching the Google Analytics session (premium only).",false,"ga:dcmClickAdId")
		{
			
		}
	}
}

