using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	DCM ad ID of the DCM click matching the Google Analytics session (premium only).
	/// </summary>
	[Description("DCM ad ID of the DCM click matching the Google Analytics session (premium only).")]
	public class DcmClickAdId: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="DcmClickAdId" />.
		/// </summary>
		public DcmClickAdId(): base("DFA Ad ID (GA Model)",false,"ga:dcmClickAdId")
		{
			
		}
	}
}

