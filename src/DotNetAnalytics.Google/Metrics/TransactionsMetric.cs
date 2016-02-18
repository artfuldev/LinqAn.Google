namespace DotNetAnalytics.Google.Metrics
{
	public class TransactionsMetric: Metric<int>
	{
		/// <summary>
		/// 	The total number of transactions.
		/// </summary>
		public TransactionsMetric(): base("Transactions","The total number of transactions.",true,"ga:transactions")
		{
			
		}
	}
}

