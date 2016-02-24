using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The average amount of elapsed time.
	/// </summary>
	[Description("The average amount of elapsed time.")]
	public class AvgUserTimingValue: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="AvgUserTimingValue" />.
		/// </summary>
		public AvgUserTimingValue(): base("Avg. User Timing (sec)",false,"ga:avgUserTimingValue")
		{
			
		}
	}
}

