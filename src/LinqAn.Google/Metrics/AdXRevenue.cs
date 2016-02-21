namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The total estimated revenue from AdX ads.
	/// </summary>
	public class AdxRevenue: Metric<decimal>
	{
		/// <summary>
	/// 	Instantiates a <seealso cref="AdxRevenue" />.
		/// </summary>
		public AdxRevenue(): base("AdX Revenue","The total estimated revenue from AdX ads.",true,"ga:adxRevenue")
		{
			
		}
	}
}

