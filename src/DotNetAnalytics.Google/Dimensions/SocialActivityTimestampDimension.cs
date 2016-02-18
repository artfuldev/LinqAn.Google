namespace DotNetAnalytics.Google.Dimensions
{
	/// <summary>
	/// 	For a social data hub activity, this value represents when the social activity occurred on the social network.
	/// </summary>
	public class SocialActivityTimestampDimension: Dimension<string>
	{
		/// <summary>
	/// 	Instantiates a <seealso cref="SocialActivityTimestampDimension" />.
		/// </summary>
		public SocialActivityTimestampDimension(): base("Social Activity Timestamp","For a social data hub activity, this value represents when the social activity occurred on the social network.",false,"ga:socialActivityTimestamp")
		{
			
		}
	}
}

