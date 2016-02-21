namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	Total refund amount for the transaction in the local currency (Enhanced Ecommerce).
	/// </summary>
	public class LocalRefundAmount: Metric<decimal>
	{
		/// <summary>
	/// 	Instantiates a <seealso cref="LocalRefundAmount" />.
		/// </summary>
		public LocalRefundAmount(): base("Local Refund Amount","Total refund amount for the transaction in the local currency (Enhanced Ecommerce).",true,"ga:localRefundAmount")
		{
			
		}
	}
}

