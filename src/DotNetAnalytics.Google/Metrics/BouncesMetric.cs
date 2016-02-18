namespace DotNetAnalytics.Google.Metrics
{
	public class BouncesMetric: Metric<int>
	{
		/// <summary>
		/// 	The total number of single page (or single engagement hit) sessions for your property.
		/// </summary>
		public BouncesMetric(): base("Bounces","The total number of single page (or single engagement hit) sessions for your property.",true,"ga:bounces")
		{
			
		}
	}
}

