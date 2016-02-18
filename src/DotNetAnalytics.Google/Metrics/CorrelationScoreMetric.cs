namespace DotNetAnalytics.Google.Metrics
{
	public class CorrelationScoreMetric: Metric<decimal>
	{
		public CorrelationScoreMetric(): base("Correlation Score","Correlation Score for related products.",false,"ga:correlationScore")
		{
			
		}
	}
}

