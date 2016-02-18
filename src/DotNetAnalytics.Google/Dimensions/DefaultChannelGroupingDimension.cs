namespace DotNetAnalytics.Google.Dimensions
{
	/// <summary>
	/// 	The default channel grouping that is shared within the View (Profile).
	/// </summary>
	public class DefaultChannelGroupingDimension: Dimension<string>
	{
		/// <summary>
	/// 	Instantiates a <seealso cref="DefaultChannelGroupingDimension" />.
		/// </summary>
		public DefaultChannelGroupingDimension(): base("Default Channel Grouping","The default channel grouping that is shared within the View (Profile).",true,"ga:channelGrouping")
		{
			
		}
	}
}

