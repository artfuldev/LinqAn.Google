namespace DotNetAnalytics.Google.Metrics
{
	public class DFAConversionsMetric: Metric<int>
	{
		/// <summary>
		/// 	The number of DCM Floodlight conversions (premium only).
		/// </summary>
		public DFAConversionsMetric(): base("DFA Conversions","The number of DCM Floodlight conversions (premium only).",false,"ga:dcmFloodlightQuantity")
		{
			
		}
	}
}

