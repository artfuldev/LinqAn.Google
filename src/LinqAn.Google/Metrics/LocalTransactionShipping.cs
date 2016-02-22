using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	Transaction shipping cost in local currency.
	/// </summary>
	[Description("Transaction shipping cost in local currency.")]
	public class LocalTransactionShipping: Metric<decimal>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="LocalTransactionShipping" />.
		/// </summary>
		public LocalTransactionShipping(): base("Local Shipping",false,"ga:localTransactionShipping")
		{
			
		}
	}
}

