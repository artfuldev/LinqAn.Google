namespace DotNetAnalytics.Google.Dimensions
{
	public class AdWordsCampaignIDDimension: Dimension<string>
	{
		/// <summary>
		/// 	A string. Corresponds to AdWords API Campaign.id.
		/// </summary>
		public AdWordsCampaignIDDimension(): base("AdWords Campaign ID","A string. Corresponds to AdWords API Campaign.id.",false,"ga:adwordsCampaignID")
		{
			
		}
	}
}

