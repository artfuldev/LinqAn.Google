using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The total number of transactions divided by the total number of users.
	/// </summary>
	[Description("The total number of transactions divided by the total number of users.")]
	public class TransactionsPerUser: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="TransactionsPerUser" />.
		/// </summary>
		public TransactionsPerUser(): base("Transactions per User",false,"ga:transactionsPerUser")
		{
			
		}
	}
}

