namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The transaction ID for the shopping cart purchase as supplied by your ecommerce tracking method.
	/// </summary>
	public class TransactionId: Dimension<string>
	{
		/// <summary>
	/// 	Instantiates a <seealso cref="TransactionId" />.
		/// </summary>
		public TransactionId(): base("Transaction ID","The transaction ID for the shopping cart purchase as supplied by your ecommerce tracking method.",true,"ga:transactionId")
		{
			
		}
	}
}

