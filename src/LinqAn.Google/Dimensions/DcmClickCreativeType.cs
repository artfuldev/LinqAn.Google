using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	DCM creative type name of the DCM click matching the Google Analytics session (premium only).
	/// </summary>
	[Description("DCM creative type name of the DCM click matching the Google Analytics session (premium only).")]
	public class DcmClickCreativeType: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="DcmClickCreativeType" />.
		/// </summary>
		public DcmClickCreativeType(): base("DFA Creative Type (GA Model)",false,"ga:dcmClickCreativeType")
		{
			
		}
	}
}

