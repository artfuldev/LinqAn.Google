namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The default channel grouping that is shared within the View (Profile).
	/// </summary>
	public class ChannelGrouping: Dimension<string>
	{
		/// <summary>
	/// 	Instantiates a <seealso cref="ChannelGrouping" />.
		/// </summary>
		public ChannelGrouping(): base("Default Channel Grouping","The default channel grouping that is shared within the View (Profile).",true,"ga:channelGrouping")
		{
			
		}
	}
}

