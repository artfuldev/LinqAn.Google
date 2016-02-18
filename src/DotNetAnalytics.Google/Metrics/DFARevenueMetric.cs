namespace DotNetAnalytics.Google.Metrics
{
	/// <summary>
	/// 	DCM Floodlight revenue (premium only).
	/// </summary>
	public class DFARevenueMetric: Metric<decimal>
	{
		/// <summary>
	/// 	Instantiates a <seealso cref="DFARevenueMetric" />.
		/// </summary>
		public DFARevenueMetric(): base("DFA Revenue","DCM Floodlight revenue (premium only).",false,"ga:dcmFloodlightRevenue")
		{
			
		}
	}
}

