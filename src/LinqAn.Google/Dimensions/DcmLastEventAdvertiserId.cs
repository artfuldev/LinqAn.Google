using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	DCM advertiser ID of the last DCM event (impression or click within the DCM lookback window) associated with the Google Analytics session (premium only).
	/// </summary>
	[Description("DCM advertiser ID of the last DCM event (impression or click within the DCM lookback window) associated with the Google Analytics session (premium only).")]
	public class DcmLastEventAdvertiserId: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="DcmLastEventAdvertiserId" />.
		/// </summary>
		public DcmLastEventAdvertiserId(): base("DFA Advertiser ID (DFA Model)",false,"ga:dcmLastEventAdvertiserId")
		{
			
		}
	}
}

