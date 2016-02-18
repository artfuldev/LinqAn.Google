namespace DotNetAnalytics.Google.Dimensions
{
	public class DFARenderingIDGAModelDimension: Dimension<string>
	{
		/// <summary>
		/// 	DCM rendering ID of the DCM click matching the Google Analytics session (premium only).
		/// </summary>
		public DFARenderingIDGAModelDimension(): base("DFA Rendering ID (GA Model)","DCM rendering ID of the DCM click matching the Google Analytics session (premium only).",false,"ga:dcmClickRenderingId")
		{
			
		}
	}
}

