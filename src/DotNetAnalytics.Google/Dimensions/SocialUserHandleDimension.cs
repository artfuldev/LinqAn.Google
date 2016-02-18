namespace DotNetAnalytics.Google.Dimensions
{
	public class SocialUserHandleDimension: Dimension<string>
	{
		/// <summary>
		/// 	For a social data hub activity, this value represents the social network handle (e.g. name or ID) of the user who initiated the social activity.
		/// </summary>
		public SocialUserHandleDimension(): base("Social User Handle","For a social data hub activity, this value represents the social network handle (e.g. name or ID) of the user who initiated the social activity.",false,"ga:socialActivityUserHandle")
		{
			
		}
	}
}

