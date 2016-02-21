namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The total sale revenue provided in the transaction excluding shipping and tax.
	/// </summary>
	public class TransactionRevenue: Metric<decimal>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="TransactionRevenue" />.
		/// </summary>
		public TransactionRevenue(): base("Revenue","The total sale revenue provided in the transaction excluding shipping and tax.",true,"ga:transactionRevenue")
		{
			
		}
	}
}

