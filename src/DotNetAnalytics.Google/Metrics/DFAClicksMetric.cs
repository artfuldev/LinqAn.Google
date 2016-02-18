namespace DotNetAnalytics.Google.Metrics
{
	public class DFAClicksMetric: Metric<int>
	{
		public DFAClicksMetric(): base("DFA Clicks","DCM Total Clicks (premium only).",false,"ga:dcmClicks")
		{
			
		}
	}
}

