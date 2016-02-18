namespace DotNetAnalytics.Google.Metrics
{
	public class DFACPCMetric: Metric<decimal>
	{
		/// <summary>
		/// 	DCM Cost Per Click (premium only).
		/// </summary>
		public DFACPCMetric(): base("DFA CPC","DCM Cost Per Click (premium only).",false,"ga:dcmCPC")
		{
			
		}
	}
}

