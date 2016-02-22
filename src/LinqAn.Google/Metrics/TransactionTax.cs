using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The total amount of tax.
	/// </summary>
	[Description("The total amount of tax.")]
	public class TransactionTax: Metric<decimal>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="TransactionTax" />.
		/// </summary>
		public TransactionTax(): base("Tax",true,"ga:transactionTax")
		{
			
		}
	}
}

