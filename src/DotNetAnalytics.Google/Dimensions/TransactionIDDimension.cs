namespace DotNetAnalytics.Google.Dimensions
{
	/// <summary>
	/// 	The transaction ID for the shopping cart purchase as supplied by your ecommerce tracking method.
	/// </summary>
	public class TransactionIDDimension: Dimension<string>
	{
		/// <summary>
	/// 	Instantiates a <seealso cref="TransactionIDDimension" />.
		/// </summary>
		public TransactionIDDimension(): base("Transaction ID","The transaction ID for the shopping cart purchase as supplied by your ecommerce tracking method.",true,"ga:transactionId")
		{
			
		}
	}
}

