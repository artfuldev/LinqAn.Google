using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The transaction ID for the shopping cart purchase as supplied by your ecommerce tracking method.
	/// </summary>
	[Description("The transaction ID for the shopping cart purchase as supplied by your ecommerce tracking method.")]
	public class TransactionId: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="TransactionId" />.
		/// </summary>
		public TransactionId(): base("Transaction ID",true,"ga:transactionId")
		{
			
		}
	}
}

