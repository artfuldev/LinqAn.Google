namespace DotNetAnalytics.Google.Metrics
{
	public class TransactionsPerUserMetric: Metric<float>
	{
		/// <summary>
		/// 	The total number of transactions divided by the total number of users.
		/// </summary>
		public TransactionsPerUserMetric(): base("Transactions per User","The total number of transactions divided by the total number of users.",false,"ga:transactionsPerUser")
		{
			
		}
	}
}

