namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The total number of transactions.
	/// </summary>
	public class Transactions: Metric<int>
	{
		/// <summary>
	/// 	Instantiates a <seealso cref="Transactions" />.
		/// </summary>
		public Transactions(): base("Transactions","The total number of transactions.",true,"ga:transactions")
		{
			
		}
	}
}

