namespace DotNetAnalytics.Google.Metrics
{
	public class DFAClicksMetric: Metric<int>
	{
		/// <summary>
		/// 	DCM Total Clicks (premium only).
		/// </summary>
		public DFAClicksMetric(): base("DFA Clicks","DCM Total Clicks (premium only).",false,"ga:dcmClicks")
		{
			
		}
	}
}

