namespace DotNetAnalytics.Google.Metrics
{
	public class DFACTRMetric: Metric<float>
	{
		/// <summary>
		/// 	DCM Click Through Rate (premium only).
		/// </summary>
		public DFACTRMetric(): base("DFA CTR","DCM Click Through Rate (premium only).",false,"ga:dcmCTR")
		{
			
		}
	}
}

