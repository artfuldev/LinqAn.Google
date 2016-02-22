using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	DCM rendering ID of the DCM click matching the Google Analytics session (premium only).
	/// </summary>
	[Description("DCM rendering ID of the DCM click matching the Google Analytics session (premium only).")]
	public class DcmClickRenderingId: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="DcmClickRenderingId" />.
		/// </summary>
		public DcmClickRenderingId(): base("DFA Rendering ID (GA Model)",false,"ga:dcmClickRenderingId")
		{
			
		}
	}
}

