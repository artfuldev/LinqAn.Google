namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	DCM ad type name of the last DCM event (impression or click within the DCM lookback window) associated with the Google Analytics session (premium only).
	/// </summary>
	public class DcmLastEventAdType: Dimension<string>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="DcmLastEventAdType" />.
		/// </summary>
		public DcmLastEventAdType(): base("DFA Ad Type (DFA Model)","DCM ad type name of the last DCM event (impression or click within the DCM lookback window) associated with the Google Analytics session (premium only).",false,"ga:dcmLastEventAdType")
		{
			
		}
	}
}

