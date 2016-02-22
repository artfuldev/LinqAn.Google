using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	DCM creative version of the DCM click matching the Google Analytics session (premium only).
	/// </summary>
	[Description("DCM creative version of the DCM click matching the Google Analytics session (premium only).")]
	public class DcmClickCreativeVersion: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="DcmClickCreativeVersion" />.
		/// </summary>
		public DcmClickCreativeVersion(): base("DFA Creative Version (GA Model)",false,"ga:dcmClickCreativeVersion")
		{
			
		}
	}
}

