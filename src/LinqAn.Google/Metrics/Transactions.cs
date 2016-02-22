using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The total number of transactions.
	/// </summary>
	[Description("The total number of transactions.")]
	public class Transactions: Metric<int>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Transactions" />.
		/// </summary>
		public Transactions(): base("Transactions",true,"ga:transactions")
		{
			
		}
	}
}

