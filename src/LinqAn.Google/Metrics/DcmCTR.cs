using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	DCM Click Through Rate (premium only).
	/// </summary>
	[Description("DCM Click Through Rate (premium only).")]
	public class DcmCTR: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="DcmCTR" />.
		/// </summary>
		public DcmCTR(): base("DFA CTR",false,"ga:dcmCTR")
		{
			
		}
	}
}

