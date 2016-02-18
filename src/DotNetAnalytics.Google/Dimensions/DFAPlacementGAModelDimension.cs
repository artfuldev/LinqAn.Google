namespace DotNetAnalytics.Google.Dimensions
{
	public class DFAPlacementGAModelDimension: Dimension<string>
	{
		/// <summary>
		/// 	DCM site placement name of the DCM click matching the Google Analytics session (premium only).
		/// </summary>
		public DFAPlacementGAModelDimension(): base("DFA Placement (GA Model)","DCM site placement name of the DCM click matching the Google Analytics session (premium only).",false,"ga:dcmClickSitePlacement")
		{
			
		}
	}
}

