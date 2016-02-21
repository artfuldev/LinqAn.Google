namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	DCM creative version of the last DCM event (impression or click within the DCM lookback window) associated with the Google Analytics session (premium only).
	/// </summary>
	public class DcmLastEventCreativeVersion: Dimension<string>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="DcmLastEventCreativeVersion" />.
		/// </summary>
		public DcmLastEventCreativeVersion(): base("DFA Creative Version (DFA Model)","DCM creative version of the last DCM event (impression or click within the DCM lookback window) associated with the Google Analytics session (premium only).",false,"ga:dcmLastEventCreativeVersion")
		{
			
		}
	}
}

