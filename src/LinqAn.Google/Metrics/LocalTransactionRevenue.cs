namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	Transaction revenue in local currency.
	/// </summary>
	public class LocalTransactionRevenue: Metric<decimal>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="LocalTransactionRevenue" />.
		/// </summary>
		public LocalTransactionRevenue(): base("Local Revenue","Transaction revenue in local currency.",false,"ga:localTransactionRevenue")
		{
			
		}
	}
}

