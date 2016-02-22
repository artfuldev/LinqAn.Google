namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	DCM advertiser name of the DCM click matching the Google Analytics session (premium only).
	/// </summary>
	public class DcmClickAdvertiser: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="DcmClickAdvertiser" />.
		/// </summary>
		public DcmClickAdvertiser(): base("DFA Advertiser (GA Model)","DCM advertiser name of the DCM click matching the Google Analytics session (premium only).",false,"ga:dcmClickAdvertiser")
		{
			
		}
	}
}

