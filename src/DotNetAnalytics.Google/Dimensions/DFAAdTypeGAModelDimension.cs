namespace DotNetAnalytics.Google.Dimensions
{
	public class DFAAdTypeGAModelDimension: Dimension<string>
	{
		/// <summary>
		/// 	DCM ad type name of the DCM click matching the Google Analytics session (premium only).
		/// </summary>
		public DFAAdTypeGAModelDimension(): base("DFA Ad Type (GA Model)","DCM ad type name of the DCM click matching the Google Analytics session (premium only).",false,"ga:dcmClickAdType")
		{
			
		}
	}
}

