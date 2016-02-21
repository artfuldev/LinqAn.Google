namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	DCM Click Through Rate (premium only).
	/// </summary>
	public class DcmCTR: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="DcmCTR" />.
		/// </summary>
		public DcmCTR(): base("DFA CTR","DCM Click Through Rate (premium only).",false,"ga:dcmCTR")
		{
			
		}
	}
}

