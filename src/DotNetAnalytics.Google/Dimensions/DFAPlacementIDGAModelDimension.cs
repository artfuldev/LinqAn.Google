namespace DotNetAnalytics.Google.Dimensions
{
	/// <summary>
	/// 	DCM site placement ID of the DCM click matching the Google Analytics session (premium only).
	/// </summary>
	public class DFAPlacementIDGAModelDimension: Dimension<string>
	{
		/// <summary>
	/// 	Instantiates a <seealso cref="DFAPlacementIDGAModelDimension" />.
		/// </summary>
		public DFAPlacementIDGAModelDimension(): base("DFA Placement ID (GA Model)","DCM site placement ID of the DCM click matching the Google Analytics session (premium only).",false,"ga:dcmClickSitePlacementId")
		{
			
		}
	}
}

