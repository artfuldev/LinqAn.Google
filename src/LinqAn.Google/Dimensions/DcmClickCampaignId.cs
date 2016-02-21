namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	DCM campaign ID of the DCM click matching the Google Analytics session (premium only).
	/// </summary>
	public class DcmClickCampaignId: Dimension<string>
	{
		/// <summary>
	/// 	Instantiates a <seealso cref="DcmClickCampaignId" />.
		/// </summary>
		public DcmClickCampaignId(): base("DFA Campaign ID (GA Model)","DCM campaign ID of the DCM click matching the Google Analytics session (premium only).",false,"ga:dcmClickCampaignId")
		{
			
		}
	}
}

