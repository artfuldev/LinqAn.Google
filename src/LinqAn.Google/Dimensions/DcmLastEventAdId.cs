using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	DCM ad ID of the last DCM event (impression or click within the DCM lookback window) associated with the Google Analytics session (premium only).
	/// </summary>
	[Description("DCM ad ID of the last DCM event (impression or click within the DCM lookback window) associated with the Google Analytics session (premium only).")]
	public class DcmLastEventAdId: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="DcmLastEventAdId" />.
		/// </summary>
		public DcmLastEventAdId(): base("DFA Ad ID (DFA Model)",false,"ga:dcmLastEventAdId")
		{
			
		}
	}
}

