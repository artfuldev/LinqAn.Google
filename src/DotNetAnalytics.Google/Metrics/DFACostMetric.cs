namespace DotNetAnalytics.Google.Metrics
{
	public class DFACostMetric: Metric<decimal>
	{
		public DFACostMetric(): base("DFA Cost","DCM Total Cost (premium only).",false,"ga:dcmCost")
		{
			
		}
	}
}

