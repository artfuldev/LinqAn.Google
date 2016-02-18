namespace DotNetAnalytics.Google.Metrics
{
	/// <summary>
	/// 	The sample set (or count) of pageviews used to calculate the average page load time.
	/// </summary>
	public class PageLoadSampleMetric: Metric<int>
	{
		/// <summary>
	/// 	Instantiates a <seealso cref="PageLoadSampleMetric" />.
		/// </summary>
		public PageLoadSampleMetric(): base("Page Load Sample","The sample set (or count) of pageviews used to calculate the average page load time.",false,"ga:pageLoadSample")
		{
			
		}
	}
}

