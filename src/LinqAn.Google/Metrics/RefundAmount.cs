namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	Currency amount refunded for a transaction (Enhanced Ecommerce).
	/// </summary>
	public class RefundAmount: Metric<decimal>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="RefundAmount" />.
		/// </summary>
		public RefundAmount(): base("Refund Amount","Currency amount refunded for a transaction (Enhanced Ecommerce).",true,"ga:refundAmount")
		{
			
		}
	}
}

