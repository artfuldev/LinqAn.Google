namespace DotNetAnalytics.Google.Metrics
{
	/// <summary>
	/// 	DCM Return On Ad Spend (ROAS) (premium only).
	/// </summary>
	public class DFAROASMetric: Metric<float>
	{
		/// <summary>
	/// 	Instantiates a <seealso cref="DFAROASMetric" />.
		/// </summary>
		public DFAROASMetric(): base("DFA ROAS","DCM Return On Ad Spend (ROAS) (premium only).",false,"ga:dcmROAS")
		{
			
		}
	}
}

