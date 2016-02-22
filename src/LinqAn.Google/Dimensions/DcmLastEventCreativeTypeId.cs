using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	DCM creative type ID of the last DCM event (impression or click within the DCM lookback window) associated with the Google Analytics session (premium only).
	/// </summary>
	[Description("DCM creative type ID of the last DCM event (impression or click within the DCM lookback window) associated with the Google Analytics session (premium only).")]
	public class DcmLastEventCreativeTypeId: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="DcmLastEventCreativeTypeId" />.
		/// </summary>
		public DcmLastEventCreativeTypeId(): base("DFA Creative Type ID (DFA Model)",false,"ga:dcmLastEventCreativeTypeId")
		{
			
		}
	}
}

