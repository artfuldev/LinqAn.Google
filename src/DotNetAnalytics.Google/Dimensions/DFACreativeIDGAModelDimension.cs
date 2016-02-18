namespace DotNetAnalytics.Google.Dimensions
{
	public class DFACreativeIDGAModelDimension: Dimension<string>
	{
		/// <summary>
		/// 	DCM creative ID of the DCM click matching the Google Analytics session (premium only).
		/// </summary>
		public DFACreativeIDGAModelDimension(): base("DFA Creative ID (GA Model)","DCM creative ID of the DCM click matching the Google Analytics session (premium only).",false,"ga:dcmClickCreativeId")
		{
			
		}
	}
}

