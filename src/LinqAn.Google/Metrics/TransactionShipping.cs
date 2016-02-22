using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The total cost of shipping.
	/// </summary>
	[Description("The total cost of shipping.")]
	public class TransactionShipping: Metric<decimal>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="TransactionShipping" />.
		/// </summary>
		public TransactionShipping(): base("Shipping",true,"ga:transactionShipping")
		{
			
		}
	}
}

