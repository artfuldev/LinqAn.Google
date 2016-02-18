namespace DotNetAnalytics.Google.Metrics
{
	public class PageLoadSampleMetric: Metric<int>
	{
		/// <summary>
		/// 	The sample set (or count) of pageviews used to calculate the average page load time.
		/// </summary>
		public PageLoadSampleMetric(): base("Page Load Sample","The sample set (or count) of pageviews used to calculate the average page load time.",false,"ga:pageLoadSample")
		{
			
		}
	}
}

