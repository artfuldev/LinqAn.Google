using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	Total refund amount for the transaction in the local currency (Enhanced Ecommerce).
	/// </summary>
	[Description("Total refund amount for the transaction in the local currency (Enhanced Ecommerce).")]
	public class LocalRefundAmount: Metric<decimal>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="LocalRefundAmount" />.
		/// </summary>
		public LocalRefundAmount(): base("Local Refund Amount",true,"ga:localRefundAmount")
		{
			
		}
	}
}

