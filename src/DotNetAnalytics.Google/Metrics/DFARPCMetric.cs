namespace DotNetAnalytics.Google.Metrics
{
	/// <summary>
	/// 	DCM Revenue Per Click (premium only).
	/// </summary>
	public class DFARPCMetric: Metric<decimal>
	{
		/// <summary>
	/// 	Instantiates a <seealso cref="DFARPCMetric" />.
		/// </summary>
		public DFARPCMetric(): base("DFA RPC","DCM Revenue Per Click (premium only).",false,"ga:dcmRPC")
		{
			
		}
	}
}

