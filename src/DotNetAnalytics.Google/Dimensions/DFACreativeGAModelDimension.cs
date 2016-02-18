namespace DotNetAnalytics.Google.Dimensions
{
	public class DFACreativeGAModelDimension: Dimension<string>
	{
		/// <summary>
		/// 	DCM creative name of the DCM click matching the Google Analytics session (premium only).
		/// </summary>
		public DFACreativeGAModelDimension(): base("DFA Creative (GA Model)","DCM creative name of the DCM click matching the Google Analytics session (premium only).",false,"ga:dcmClickCreative")
		{
			
		}
	}
}

