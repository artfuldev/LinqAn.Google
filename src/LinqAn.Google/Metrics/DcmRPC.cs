namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	DCM Revenue Per Click (premium only).
	/// </summary>
	public class DcmRPC: Metric<decimal>
	{
		/// <summary>
	/// 	Instantiates a <seealso cref="DcmRPC" />.
		/// </summary>
		public DcmRPC(): base("DFA RPC","DCM Revenue Per Click (premium only).",false,"ga:dcmRPC")
		{
			
		}
	}
}

