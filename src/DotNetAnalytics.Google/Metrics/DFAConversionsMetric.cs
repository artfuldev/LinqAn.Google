namespace DotNetAnalytics.Google.Metrics
{
	public class DFAConversionsMetric: Metric<int>
	{
		public DFAConversionsMetric(): base("DFA Conversions","The number of DCM Floodlight conversions (premium only).",false,"ga:dcmFloodlightQuantity")
		{
			
		}
	}
}

