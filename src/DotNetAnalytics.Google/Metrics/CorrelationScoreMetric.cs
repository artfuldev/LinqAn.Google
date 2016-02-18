namespace DotNetAnalytics.Google.Metrics
{
	public class CorrelationScoreMetric: Metric<decimal>
	{
		/// <summary>
		/// 	Correlation Score for related products.
		/// </summary>
		public CorrelationScoreMetric(): base("Correlation Score","Correlation Score for related products.",false,"ga:correlationScore")
		{
			
		}
	}
}

