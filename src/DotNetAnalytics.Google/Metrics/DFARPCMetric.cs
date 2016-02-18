namespace DotNetAnalytics.Google.Metrics
{
	public class DFARPCMetric: Metric<decimal>
	{
		/// <summary>
		/// 	DCM Revenue Per Click (premium only).
		/// </summary>
		public DFARPCMetric(): base("DFA RPC","DCM Revenue Per Click (premium only).",false,"ga:dcmRPC")
		{
			
		}
	}
}

