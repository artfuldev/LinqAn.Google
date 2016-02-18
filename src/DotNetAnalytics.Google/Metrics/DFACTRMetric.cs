namespace DotNetAnalytics.Google.Metrics
{
	/// <summary>
	/// 	DCM Click Through Rate (premium only).
	/// </summary>
	public class DFACTRMetric: Metric<float>
	{
		/// <summary>
	/// 	Instantiates a <seealso cref="DFACTRMetric" />.
		/// </summary>
		public DFACTRMetric(): base("DFA CTR","DCM Click Through Rate (premium only).",false,"ga:dcmCTR")
		{
			
		}
	}
}

