using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	DCM ad name of the last DCM event (impression or click within the DCM lookback window) associated with the Google Analytics session (premium only).
	/// </summary>
	[Description("DCM ad name of the last DCM event (impression or click within the DCM lookback window) associated with the Google Analytics session (premium only).")]
	public class DcmLastEventAd: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="DcmLastEventAd" />.
		/// </summary>
		public DcmLastEventAd(): base("DFA Ad",false,"ga:dcmLastEventAd")
		{
			
		}
	}
}

