namespace DotNetAnalytics.Google.Dimensions
{
	public class TransactionIDDimension: Dimension<string>
	{
		/// <summary>
		/// 	The transaction ID for the shopping cart purchase as supplied by your ecommerce tracking method.
		/// </summary>
		public TransactionIDDimension(): base("Transaction ID","The transaction ID for the shopping cart purchase as supplied by your ecommerce tracking method.",true,"ga:transactionId")
		{
			
		}
	}
}

