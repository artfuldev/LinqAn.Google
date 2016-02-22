using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	Site name where the DCM creative was shown and clicked on for the DCM click matching the Google Analytics session (premium only).
	/// </summary>
	[Description("Site name where the DCM creative was shown and clicked on for the DCM click matching the Google Analytics session (premium only).")]
	public class DcmClickSite: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="DcmClickSite" />.
		/// </summary>
		public DcmClickSite(): base("DFA Site (GA Model)",false,"ga:dcmClickSite")
		{
			
		}
	}
}

