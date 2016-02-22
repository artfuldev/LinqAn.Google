using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	Site name where the DCM creative was shown and clicked on for the last DCM event (impression or click within the DCM lookback window) associated with the Google Analytics session (premium only).
	/// </summary>
	[Description("Site name where the DCM creative was shown and clicked on for the last DCM event (impression or click within the DCM lookback window) associated with the Google Analytics session (premium only).")]
	public class DcmLastEventSite: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="DcmLastEventSite" />.
		/// </summary>
		public DcmLastEventSite(): base("DFA Site (DFA Model)",false,"ga:dcmLastEventSite")
		{
			
		}
	}
}

