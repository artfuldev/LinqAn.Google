namespace DotNetAnalytics.Google.Metrics
{
	public class ExitsMetric: Metric<int>
	{
		public ExitsMetric(): base("Exits","The number of exits from your property.",true,"ga:exits")
		{
			
		}
	}
}

