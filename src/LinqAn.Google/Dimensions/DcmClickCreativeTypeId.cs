using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	DCM creative type ID of the DCM click matching the Google Analytics session (premium only).
	/// </summary>
	[Description("DCM creative type ID of the DCM click matching the Google Analytics session (premium only).")]
	public class DcmClickCreativeTypeId: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="DcmClickCreativeTypeId" />.
		/// </summary>
		public DcmClickCreativeTypeId(): base("DFA Creative Type ID (GA Model)",false,"ga:dcmClickCreativeTypeId")
		{
			
		}
	}
}

