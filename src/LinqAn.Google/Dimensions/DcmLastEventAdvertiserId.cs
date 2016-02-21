namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	DCM advertiser ID of the last DCM event (impression or click within the DCM lookback window) associated with the Google Analytics session (premium only).
	/// </summary>
	public class DcmLastEventAdvertiserId: Dimension<string>
	{
		/// <summary>
	/// 	Instantiates a <seealso cref="DcmLastEventAdvertiserId" />.
		/// </summary>
		public DcmLastEventAdvertiserId(): base("DFA Advertiser ID (DFA Model)","DCM advertiser ID of the last DCM event (impression or click within the DCM lookback window) associated with the Google Analytics session (premium only).",false,"ga:dcmLastEventAdvertiserId")
		{
			
		}
	}
}

