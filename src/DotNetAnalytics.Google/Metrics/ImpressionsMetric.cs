namespace DotNetAnalytics.Google.Metrics
{
	/// <summary>
	/// 	Total number of campaign impressions.
	/// </summary>
	public class ImpressionsMetric: Metric<int>
	{
		/// <summary>
	/// 	Instantiates a <seealso cref="ImpressionsMetric" />.
		/// </summary>
		public ImpressionsMetric(): base("Impressions","Total number of campaign impressions.",false,"ga:impressions")
		{
			
		}
	}
}

