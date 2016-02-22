using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	DCM Floodlight advertiser ID associated with the floodlight conversion (premium only).
	/// </summary>
	[Description("DCM Floodlight advertiser ID associated with the floodlight conversion (premium only).")]
	public class DcmFloodlightAdvertiserId: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="DcmFloodlightAdvertiserId" />.
		/// </summary>
		public DcmFloodlightAdvertiserId(): base("DFA Advertiser ID",false,"ga:dcmFloodlightAdvertiserId")
		{
			
		}
	}
}

