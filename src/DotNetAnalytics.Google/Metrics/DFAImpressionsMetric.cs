namespace DotNetAnalytics.Google.Metrics
{
	/// <summary>
	/// 	DCM Total Impressions (premium only).
	/// </summary>
	public class DFAImpressionsMetric: Metric<int>
	{
		/// <summary>
	/// 	Instantiates a <seealso cref="DFAImpressionsMetric" />.
		/// </summary>
		public DFAImpressionsMetric(): base("DFA Impressions","DCM Total Impressions (premium only).",false,"ga:dcmImpressions")
		{
			
		}
	}
}

