namespace DotNetAnalytics.Google.Metrics
{
	/// <summary>
	/// 	The total number of times users have clicked on an ad to reach your property.
	/// </summary>
	public class ClicksMetric: Metric<int>
	{
		/// <summary>
	/// 	Instantiates a <seealso cref="ClicksMetric" />.
		/// </summary>
		public ClicksMetric(): base("Clicks","The total number of times users have clicked on an ad to reach your property.",false,"ga:adClicks")
		{
			
		}
	}
}

