namespace DotNetAnalytics.Google.Metrics
{
	public class ScreenViewsMetric: Metric<int>
	{
		/// <summary>
		/// 	The total number of screenviews.
		/// </summary>
		public ScreenViewsMetric(): base("Screen Views","The total number of screenviews.",true,"ga:screenviews")
		{
			
		}
	}
}

