namespace DotNetAnalytics.Google.Dimensions
{
	public class DFACreativeVersionGAModelDimension: Dimension<string>
	{
		/// <summary>
		/// 	DCM creative version of the DCM click matching the Google Analytics session (premium only).
		/// </summary>
		public DFACreativeVersionGAModelDimension(): base("DFA Creative Version (GA Model)","DCM creative version of the DCM click matching the Google Analytics session (premium only).",false,"ga:dcmClickCreativeVersion")
		{
			
		}
	}
}

