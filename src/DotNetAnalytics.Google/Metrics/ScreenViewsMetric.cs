namespace DotNetAnalytics.Google.Metrics
{
	public class ScreenViewsMetric: Metric<int>
	{
		public ScreenViewsMetric(): base("Screen Views","The total number of screenviews.",true,"ga:screenviews")
		{
			
		}
	}
}

