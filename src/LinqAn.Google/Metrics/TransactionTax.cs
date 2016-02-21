namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The total amount of tax.
	/// </summary>
	public class TransactionTax: Metric<decimal>
	{
		/// <summary>
	/// 	Instantiates a <seealso cref="TransactionTax" />.
		/// </summary>
		public TransactionTax(): base("Tax","The total amount of tax.",true,"ga:transactionTax")
		{
			
		}
	}
}

