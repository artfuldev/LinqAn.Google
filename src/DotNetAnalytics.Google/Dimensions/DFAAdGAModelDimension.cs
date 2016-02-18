namespace DotNetAnalytics.Google.Dimensions
{
	public class DFAAdGAModelDimension: Dimension<string>
	{
		/// <summary>
		/// 	DCM ad name of the DCM click matching the Google Analytics session (premium only).
		/// </summary>
		public DFAAdGAModelDimension(): base("DFA Ad (GA Model)","DCM ad name of the DCM click matching the Google Analytics session (premium only).",false,"ga:dcmClickAd")
		{
			
		}
	}
}

