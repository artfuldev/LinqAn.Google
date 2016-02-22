using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The total sale revenue provided in the transaction excluding shipping and tax.
	/// </summary>
	[Description("The total sale revenue provided in the transaction excluding shipping and tax.")]
	public class TransactionRevenue: Metric<decimal>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="TransactionRevenue" />.
		/// </summary>
		public TransactionRevenue(): base("Revenue",true,"ga:transactionRevenue")
		{
			
		}
	}
}

