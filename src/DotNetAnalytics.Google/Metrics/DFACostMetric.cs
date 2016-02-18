namespace DotNetAnalytics.Google.Metrics
{
	public class DFACostMetric: Metric<decimal>
	{
		/// <summary>
		/// 	DCM Total Cost (premium only).
		/// </summary>
		public DFACostMetric(): base("DFA Cost","DCM Total Cost (premium only).",false,"ga:dcmCost")
		{
			
		}
	}
}

