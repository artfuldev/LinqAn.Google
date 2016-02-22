namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	DCM campaign name of the DCM click matching the Google Analytics session (premium only).
	/// </summary>
	public class DcmClickCampaign: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="DcmClickCampaign" />.
		/// </summary>
		public DcmClickCampaign(): base("DFA Campaign (GA Model)","DCM campaign name of the DCM click matching the Google Analytics session (premium only).",false,"ga:dcmClickCampaign")
		{
			
		}
	}
}

