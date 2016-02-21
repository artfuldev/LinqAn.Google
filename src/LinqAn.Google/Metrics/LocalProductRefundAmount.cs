namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	Refund amount for a given product in the local currency (Enhanced Ecommerce).
	/// </summary>
	public class LocalProductRefundAmount: Metric<decimal>
	{
		/// <summary>
	/// 	Instantiates a <seealso cref="LocalProductRefundAmount" />.
		/// </summary>
		public LocalProductRefundAmount(): base("Local Product Refund Amount","Refund amount for a given product in the local currency (Enhanced Ecommerce).",true,"ga:localProductRefundAmount")
		{
			
		}
	}
}

