namespace DotNetAnalytics.Google.Dimensions
{
	/// <summary>
	/// 	DCM ad type name of the DCM click matching the Google Analytics session (premium only).
	/// </summary>
	public class DFAAdTypeGAModelDimension: Dimension<string>
	{
		/// <summary>
	/// 	Instantiates a <seealso cref="DFAAdTypeGAModelDimension" />.
		/// </summary>
		public DFAAdTypeGAModelDimension(): base("DFA Ad Type (GA Model)","DCM ad type name of the DCM click matching the Google Analytics session (premium only).",false,"ga:dcmClickAdType")
		{
			
		}
	}
}

