using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	DCM site ID where the DCM creative was shown and clicked on for the DCM click matching the Google Analytics session (premium only).
	/// </summary>
	[Description("DCM site ID where the DCM creative was shown and clicked on for the DCM click matching the Google Analytics session (premium only).")]
	public class DcmClickSiteId: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="DcmClickSiteId" />.
		/// </summary>
		public DcmClickSiteId(): base("DFA Site ID (GA Model)",false,"ga:dcmClickSiteId")
		{
			
		}
	}
}

