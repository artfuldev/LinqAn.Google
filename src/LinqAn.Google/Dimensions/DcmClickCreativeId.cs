using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	DCM creative ID of the DCM click matching the Google Analytics session (premium only).
	/// </summary>
	[Description("DCM creative ID of the DCM click matching the Google Analytics session (premium only).")]
	public class DcmClickCreativeId: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="DcmClickCreativeId" />.
		/// </summary>
		public DcmClickCreativeId(): base("DFA Creative ID (GA Model)",false,"ga:dcmClickCreativeId")
		{
			
		}
	}
}

