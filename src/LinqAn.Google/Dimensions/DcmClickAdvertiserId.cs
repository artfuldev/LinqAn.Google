namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	DCM advertiser ID of the DCM click matching the Google Analytics session (premium only).
	/// </summary>
	public class DcmClickAdvertiserId: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="DcmClickAdvertiserId" />.
		/// </summary>
		public DcmClickAdvertiserId(): base("DFA Advertiser ID (GA Model)","DCM advertiser ID of the DCM click matching the Google Analytics session (premium only).",false,"ga:dcmClickAdvertiserId")
		{
			
		}
	}
}

