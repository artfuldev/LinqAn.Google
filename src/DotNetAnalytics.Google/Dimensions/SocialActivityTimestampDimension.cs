namespace DotNetAnalytics.Google.Dimensions
{
	public class SocialActivityTimestampDimension: Dimension<string>
	{
		/// <summary>
		/// 	For a social data hub activity, this value represents when the social activity occurred on the social network.
		/// </summary>
		public SocialActivityTimestampDimension(): base("Social Activity Timestamp","For a social data hub activity, this value represents when the social activity occurred on the social network.",false,"ga:socialActivityTimestamp")
		{
			
		}
	}
}

