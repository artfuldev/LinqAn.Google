using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	DCM ad type ID of the last DCM event (impression or click within the DCM lookback window) associated with the Google Analytics session (premium only).
	/// </summary>
	[Description("DCM ad type ID of the last DCM event (impression or click within the DCM lookback window) associated with the Google Analytics session (premium only).")]
	public class DcmLastEventAdTypeId: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="DcmLastEventAdTypeId" />.
		/// </summary>
		public DcmLastEventAdTypeId(): base("DFA Ad Type ID (DFA Model)",false,"ga:dcmLastEventAdTypeId")
		{
			
		}
	}
}

