using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The average number of transactions for a session.
	/// </summary>
	[Description("The average number of transactions for a session.")]
	public class TransactionsPerSession: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="TransactionsPerSession" />.
		/// </summary>
		public TransactionsPerSession(): base("Ecommerce Conversion Rate",false,"ga:transactionsPerSession")
		{
			
		}
	}
}

