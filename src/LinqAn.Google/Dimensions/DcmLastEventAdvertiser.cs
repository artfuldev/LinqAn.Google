using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	DCM advertiser name of the last DCM event (impression or click within the DCM lookback window) associated with the Google Analytics session (premium only).
	/// </summary>
	[Description("DCM advertiser name of the last DCM event (impression or click within the DCM lookback window) associated with the Google Analytics session (premium only).")]
	public class DcmLastEventAdvertiser: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="DcmLastEventAdvertiser" />.
		/// </summary>
		public DcmLastEventAdvertiser(): base("DFA Advertiser (DFA Model)",false,"ga:dcmLastEventAdvertiser")
		{
			
		}
	}
}

