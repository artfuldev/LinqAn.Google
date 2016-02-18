namespace DotNetAnalytics.Google.Metrics
{
	public class UniqueScreenViewsMetric: Metric<int>
	{
		public UniqueScreenViewsMetric(): base("Unique Screen Views","The number of unique screen views. Screen views in different sessions count a separate screen views.",true,"ga:uniqueScreenviews")
		{
			
		}
	}
}

