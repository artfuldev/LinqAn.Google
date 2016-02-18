namespace DotNetAnalytics.Google.Metrics
{
	public class DFAImpressionsMetric: Metric<int>
	{
		/// <summary>
		/// 	DCM Total Impressions (premium only).
		/// </summary>
		public DFAImpressionsMetric(): base("DFA Impressions","DCM Total Impressions (premium only).",false,"ga:dcmImpressions")
		{
			
		}
	}
}

