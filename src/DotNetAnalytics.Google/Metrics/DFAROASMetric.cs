namespace DotNetAnalytics.Google.Metrics
{
	public class DFAROASMetric: Metric<float>
	{
		/// <summary>
		/// 	DCM Return On Ad Spend (ROAS) (premium only).
		/// </summary>
		public DFAROASMetric(): base("DFA ROAS","DCM Return On Ad Spend (ROAS) (premium only).",false,"ga:dcmROAS")
		{
			
		}
	}
}

