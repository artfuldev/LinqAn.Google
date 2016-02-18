namespace DotNetAnalytics.Google.Metrics
{
	public class AdXClicksMetric: Metric<int>
	{
		public AdXClicksMetric(): base("AdX Clicks","The number of times AdX ads were clicked on your site.",true,"ga:adxClicks")
		{
			
		}
	}
}

