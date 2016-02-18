namespace DotNetAnalytics.Google.Dimensions
{
	public class SocialTypeDimension: Dimension<string>
	{
		/// <summary>
		/// 	Engagement type. Possible values are "Socially Engaged" or "Not Socially Engaged".
		/// </summary>
		public SocialTypeDimension(): base("Social Type","Engagement type. Possible values are "Socially Engaged" or "Not Socially Engaged".",false,"ga:socialEngagementType")
		{
			
		}
	}
}

