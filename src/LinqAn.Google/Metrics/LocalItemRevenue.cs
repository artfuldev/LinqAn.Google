namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	Product revenue in local currency.
	/// </summary>
	public class LocalItemRevenue: Metric<decimal>
	{
		/// <summary>
	/// 	Instantiates a <seealso cref="LocalItemRevenue" />.
		/// </summary>
		public LocalItemRevenue(): base("Local Product Revenue","Product revenue in local currency.",true,"ga:localItemRevenue")
		{
			
		}
	}
}

