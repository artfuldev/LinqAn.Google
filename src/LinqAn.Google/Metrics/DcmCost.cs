namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	DCM Total Cost (premium only).
	/// </summary>
	public class DcmCost: Metric<decimal>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="DcmCost" />.
		/// </summary>
		public DcmCost(): base("DFA Cost","DCM Total Cost (premium only).",false,"ga:dcmCost")
		{
			
		}
	}
}

