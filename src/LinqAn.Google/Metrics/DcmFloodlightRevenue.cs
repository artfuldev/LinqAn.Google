namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	DCM Floodlight revenue (premium only).
	/// </summary>
	public class DcmFloodlightRevenue: Metric<decimal>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="DcmFloodlightRevenue" />.
		/// </summary>
		public DcmFloodlightRevenue(): base("DFA Revenue","DCM Floodlight revenue (premium only).",false,"ga:dcmFloodlightRevenue")
		{
			
		}
	}
}

