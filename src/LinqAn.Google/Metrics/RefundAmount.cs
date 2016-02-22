using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	Currency amount refunded for a transaction (Enhanced Ecommerce).
	/// </summary>
	[Description("Currency amount refunded for a transaction (Enhanced Ecommerce).")]
	public class RefundAmount: Metric<decimal>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="RefundAmount" />.
		/// </summary>
		public RefundAmount(): base("Refund Amount",true,"ga:refundAmount")
		{
			
		}
	}
}

