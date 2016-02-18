namespace DotNetAnalytics.Google.Metrics
{
	public class LocalTaxMetric: Metric<decimal>
	{
		public LocalTaxMetric(): base("Local Tax","Transaction tax in local currency.",false,"ga:localTransactionTax")
		{
			
		}
	}
}

