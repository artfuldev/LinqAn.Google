namespace DotNetAnalytics.Google.Metrics
{
	/// <summary>
	/// 	The number of DCM Floodlight conversions (premium only).
	/// </summary>
	public class DFAConversionsMetric: Metric<int>
	{
		/// <summary>
	/// 	Instantiates a <seealso cref="DFAConversionsMetric" />.
		/// </summary>
		public DFAConversionsMetric(): base("DFA Conversions","The number of DCM Floodlight conversions (premium only).",false,"ga:dcmFloodlightQuantity")
		{
			
		}
	}
}

