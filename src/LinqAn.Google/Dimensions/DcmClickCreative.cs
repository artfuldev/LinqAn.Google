using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	DCM creative name of the DCM click matching the Google Analytics session (premium only).
	/// </summary>
	[Description("DCM creative name of the DCM click matching the Google Analytics session (premium only).")]
	public class DcmClickCreative: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="DcmClickCreative" />.
		/// </summary>
		public DcmClickCreative(): base("DFA Creative (GA Model)",false,"ga:dcmClickCreative")
		{
			
		}
	}
}

