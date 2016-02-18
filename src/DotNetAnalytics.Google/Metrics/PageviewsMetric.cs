namespace DotNetAnalytics.Google.Metrics
{
	public class PageviewsMetric: Metric<int>
	{
		/// <summary>
		/// 	The total number of pageviews for your property.
		/// </summary>
		public PageviewsMetric(): base("Pageviews","The total number of pageviews for your property.",true,"ga:pageviews")
		{
			
		}
	}
}

