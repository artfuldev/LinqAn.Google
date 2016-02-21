namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The total cost of shipping.
	/// </summary>
	public class TransactionShipping: Metric<decimal>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="TransactionShipping" />.
		/// </summary>
		public TransactionShipping(): base("Shipping","The total cost of shipping.",true,"ga:transactionShipping")
		{
			
		}
	}
}

