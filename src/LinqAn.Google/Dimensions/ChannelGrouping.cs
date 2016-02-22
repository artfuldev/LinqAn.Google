using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The default channel grouping that is shared within the View (Profile).
	/// </summary>
	[Description("The default channel grouping that is shared within the View (Profile).")]
	public class ChannelGrouping: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="ChannelGrouping" />.
		/// </summary>
		public ChannelGrouping(): base("Default Channel Grouping",true,"ga:channelGrouping")
		{
			
		}
	}
}

