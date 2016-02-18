namespace DotNetAnalytics.Google.Metrics
{
	public class DFARevenueMetric: Metric<decimal>
	{
		/// <summary>
		/// 	DCM Floodlight revenue (premium only).
		/// </summary>
		public DFARevenueMetric(): base("DFA Revenue","DCM Floodlight revenue (premium only).",false,"ga:dcmFloodlightRevenue")
		{
			
		}
	}
}

