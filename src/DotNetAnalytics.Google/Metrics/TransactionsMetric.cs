namespace DotNetAnalytics.Google.Metrics
{
	public class TransactionsMetric: Metric<int>
	{
		public TransactionsMetric(): base("Transactions","The total number of transactions.",true,"ga:transactions")
		{
			
		}
	}
}

