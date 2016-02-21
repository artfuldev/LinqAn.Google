namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	DCM Cost Per Click (premium only).
	/// </summary>
	public class DcmCPC: Metric<decimal>
	{
		/// <summary>
	/// 	Instantiates a <seealso cref="DcmCPC" />.
		/// </summary>
		public DcmCPC(): base("DFA CPC","DCM Cost Per Click (premium only).",false,"ga:dcmCPC")
		{
			
		}
	}
}

