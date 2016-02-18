namespace DotNetAnalytics.Google.Metrics
{
	public class ClicksMetric: Metric<int>
	{
		public ClicksMetric(): base("Clicks","The total number of times users have clicked on an ad to reach your property.",false,"ga:adClicks")
		{
			
		}
	}
}

