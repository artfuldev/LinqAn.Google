namespace DotNetAnalytics.Google.Metrics
{
	public class TransactionsPerUserMetric: Metric<float>
	{
		public TransactionsPerUserMetric(): base("Transactions per User","The total number of transactions divided by the total number of users.",false,"ga:transactionsPerUser")
		{
			
		}
	}
}

