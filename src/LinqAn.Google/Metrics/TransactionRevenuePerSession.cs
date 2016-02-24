using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	Average transaction revenue for a session.
	/// </summary>
	[Description("Average transaction revenue for a session.")]
	public class TransactionRevenuePerSession: Metric<decimal>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="TransactionRevenuePerSession" />.
		/// </summary>
		public TransactionRevenuePerSession(): base("Per Session Value",false,"ga:transactionRevenuePerSession")
		{
			
		}
	}
}

