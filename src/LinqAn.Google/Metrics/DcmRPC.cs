using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	DCM Revenue Per Click (premium only).
	/// </summary>
	[Description("DCM Revenue Per Click (premium only).")]
	public class DcmRPC: Metric<decimal>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="DcmRPC" />.
		/// </summary>
		public DcmRPC(): base("DFA RPC",false,"ga:dcmRPC")
		{
			
		}
	}
}

