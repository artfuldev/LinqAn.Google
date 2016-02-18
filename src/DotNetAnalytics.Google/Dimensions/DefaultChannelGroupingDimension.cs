namespace DotNetAnalytics.Google.Dimensions
{
	public class DefaultChannelGroupingDimension: Dimension<string>
	{
		/// <summary>
		/// 	The default channel grouping that is shared within the View (Profile).
		/// </summary>
		public DefaultChannelGroupingDimension(): base("Default Channel Grouping","The default channel grouping that is shared within the View (Profile).",true,"ga:channelGrouping")
		{
			
		}
	}
}

