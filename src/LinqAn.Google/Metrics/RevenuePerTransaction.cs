using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The average revenue for an e-commerce transaction.
	/// </summary>
	[Description("The average revenue for an e-commerce transaction.")]
	public class RevenuePerTransaction: Metric<decimal>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="RevenuePerTransaction" />.
		/// </summary>
		public RevenuePerTransaction(): base("Average Order Value",false,"ga:revenuePerTransaction")
		{
			
		}
	}
}

