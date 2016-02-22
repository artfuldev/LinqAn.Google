using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	DCM site placement ID of the DCM click matching the Google Analytics session (premium only).
	/// </summary>
	[Description("DCM site placement ID of the DCM click matching the Google Analytics session (premium only).")]
	public class DcmClickSitePlacementId: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="DcmClickSitePlacementId" />.
		/// </summary>
		public DcmClickSitePlacementId(): base("DFA Placement ID (GA Model)",false,"ga:dcmClickSitePlacementId")
		{
			
		}
	}
}

