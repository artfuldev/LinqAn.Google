using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	Transaction tax in local currency.
	/// </summary>
	[Description("Transaction tax in local currency.")]
	public class LocalTransactionTax: Metric<decimal>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="LocalTransactionTax" />.
		/// </summary>
		public LocalTransactionTax(): base("Local Tax",false,"ga:localTransactionTax")
		{
			
		}
	}
}

