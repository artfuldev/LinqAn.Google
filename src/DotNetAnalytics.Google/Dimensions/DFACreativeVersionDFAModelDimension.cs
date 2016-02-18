namespace DotNetAnalytics.Google.Dimensions
{
	/// <summary>
	/// 	DCM creative version of the last DCM event (impression or click within the DCM lookback window) associated with the Google Analytics session (premium only).
	/// </summary>
	public class DFACreativeVersionDFAModelDimension: Dimension<string>
	{
		/// <summary>
	/// 	Instantiates a <seealso cref="DFACreativeVersionDFAModelDimension" />.
		/// </summary>
		public DFACreativeVersionDFAModelDimension(): base("DFA Creative Version (DFA Model)","DCM creative version of the last DCM event (impression or click within the DCM lookback window) associated with the Google Analytics session (premium only).",false,"ga:dcmLastEventCreativeVersion")
		{
			
		}
	}
}

