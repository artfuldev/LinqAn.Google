namespace DotNetAnalytics.Google.Metrics
{
	public class ImpressionsMetric: Metric<int>
	{
		public ImpressionsMetric(): base("Impressions","Total number of campaign impressions.",false,"ga:impressions")
		{
			
		}
	}
}

