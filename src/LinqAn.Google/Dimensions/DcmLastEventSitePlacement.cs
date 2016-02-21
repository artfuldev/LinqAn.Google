namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	DCM site placement name of the last DCM event (impression or click within the DCM lookback window) associated with the Google Analytics session (premium only).
	/// </summary>
	public class DcmLastEventSitePlacement: Dimension<string>
	{
		/// <summary>
	/// 	Instantiates a <seealso cref="DcmLastEventSitePlacement" />.
		/// </summary>
		public DcmLastEventSitePlacement(): base("DFA Placement (DFA Model)","DCM site placement name of the last DCM event (impression or click within the DCM lookback window) associated with the Google Analytics session (premium only).",false,"ga:dcmLastEventSitePlacement")
		{
			
		}
	}
}

