using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	DCM creative ID of the last DCM event (impression or click within the DCM lookback window) associated with the Google Analytics session (premium only).
	/// </summary>
	[Description("DCM creative ID of the last DCM event (impression or click within the DCM lookback window) associated with the Google Analytics session (premium only).")]
	public class DcmLastEventCreativeId: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="DcmLastEventCreativeId" />.
		/// </summary>
		public DcmLastEventCreativeId(): base("DFA Creative ID (DFA Model)",false,"ga:dcmLastEventCreativeId")
		{
			
		}
	}
}

