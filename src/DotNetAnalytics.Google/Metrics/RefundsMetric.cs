namespace DotNetAnalytics.Google.Metrics
{
	/// <summary>
	/// 	Number of refunds that have been issued (Enhanced Ecommerce).
	/// </summary>
	public class RefundsMetric: Metric<int>
	{
		/// <summary>
	/// 	Instantiates a <seealso cref="RefundsMetric" />.
		/// </summary>
		public RefundsMetric(): base("Refunds","Number of refunds that have been issued (Enhanced Ecommerce).",true,"ga:totalRefunds")
		{
			
		}
	}
}

