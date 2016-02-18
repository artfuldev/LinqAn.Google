namespace DotNetAnalytics.Google.Dimensions
{
	public class CampaignCodeDimension: Dimension<string>
	{
		/// <summary>
		/// 	When using manual campaign tracking, the value of the utm_id campaign tracking parameter.
		/// </summary>
		public CampaignCodeDimension(): base("Campaign Code","When using manual campaign tracking, the value of the utm_id campaign tracking parameter.",false,"ga:campaignCode")
		{
			
		}
	}
}

