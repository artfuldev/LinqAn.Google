namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	DCM ad name of the DCM click matching the Google Analytics session (premium only).
	/// </summary>
	public class DcmClickAd: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="DcmClickAd" />.
		/// </summary>
		public DcmClickAd(): base("DFA Ad (GA Model)","DCM ad name of the DCM click matching the Google Analytics session (premium only).",false,"ga:dcmClickAd")
		{
			
		}
	}
}

