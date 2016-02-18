namespace DotNetAnalytics.Google.Metrics
{
	public class ImpressionsMetric: Metric<int>
	{
		/// <summary>
		/// 	Total number of campaign impressions.
		/// </summary>
		public ImpressionsMetric(): base("Impressions","Total number of campaign impressions.",false,"ga:impressions")
		{
			
		}
	}
}

