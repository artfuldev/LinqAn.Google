namespace DotNetAnalytics.Google.Metrics
{
	public class ExitsMetric: Metric<int>
	{
		/// <summary>
		/// 	The number of exits from your property.
		/// </summary>
		public ExitsMetric(): base("Exits","The number of exits from your property.",true,"ga:exits")
		{
			
		}
	}
}

