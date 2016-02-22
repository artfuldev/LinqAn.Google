using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	DCM site placement name of the DCM click matching the Google Analytics session (premium only).
	/// </summary>
	[Description("DCM site placement name of the DCM click matching the Google Analytics session (premium only).")]
	public class DcmClickSitePlacement: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="DcmClickSitePlacement" />.
		/// </summary>
		public DcmClickSitePlacement(): base("DFA Placement (GA Model)",false,"ga:dcmClickSitePlacement")
		{
			
		}
	}
}

