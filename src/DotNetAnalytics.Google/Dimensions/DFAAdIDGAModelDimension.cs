namespace DotNetAnalytics.Google.Dimensions
{
	/// <summary>
	/// 	DCM ad ID of the DCM click matching the Google Analytics session (premium only).
	/// </summary>
	public class DFAAdIDGAModelDimension: Dimension<string>
	{
		/// <summary>
	/// 	Instantiates a <seealso cref="DFAAdIDGAModelDimension" />.
		/// </summary>
		public DFAAdIDGAModelDimension(): base("DFA Ad ID (GA Model)","DCM ad ID of the DCM click matching the Google Analytics session (premium only).",false,"ga:dcmClickAdId")
		{
			
		}
	}
}

