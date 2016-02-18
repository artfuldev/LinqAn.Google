namespace DotNetAnalytics.Google.Metrics
{
	public class BouncesMetric: Metric<int>
	{
		public BouncesMetric(): base("Bounces","The total number of single page (or single engagement hit) sessions for your property.",true,"ga:bounces")
		{
			
		}
	}
}

