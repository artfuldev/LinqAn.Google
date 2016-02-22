using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	Transaction revenue in local currency.
	/// </summary>
	[Description("Transaction revenue in local currency.")]
	public class LocalTransactionRevenue: Metric<decimal>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="LocalTransactionRevenue" />.
		/// </summary>
		public LocalTransactionRevenue(): base("Local Revenue",false,"ga:localTransactionRevenue")
		{
			
		}
	}
}

