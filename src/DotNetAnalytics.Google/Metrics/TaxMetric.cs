namespace DotNetAnalytics.Google.Metrics
{
	public class TaxMetric: Metric<decimal>
	{
		public TaxMetric(): base("Tax","The total amount of tax.",true,"ga:transactionTax")
		{
			
		}
	}
}

