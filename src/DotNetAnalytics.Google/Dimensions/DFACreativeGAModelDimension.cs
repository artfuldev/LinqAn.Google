namespace DotNetAnalytics.Google.Dimensions
{
	/// <summary>
	/// 	DCM creative name of the DCM click matching the Google Analytics session (premium only).
	/// </summary>
	public class DFACreativeGAModelDimension: Dimension<string>
	{
		/// <summary>
	/// 	Instantiates a <seealso cref="DFACreativeGAModelDimension" />.
		/// </summary>
		public DFACreativeGAModelDimension(): base("DFA Creative (GA Model)","DCM creative name of the DCM click matching the Google Analytics session (premium only).",false,"ga:dcmClickCreative")
		{
			
		}
	}
}

