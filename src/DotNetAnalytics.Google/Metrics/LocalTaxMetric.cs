namespace DotNetAnalytics.Google.Metrics
{
	public class LocalTaxMetric: Metric<decimal>
	{
		/// <summary>
		/// 	Transaction tax in local currency.
		/// </summary>
		public LocalTaxMetric(): base("Local Tax","Transaction tax in local currency.",false,"ga:localTransactionTax")
		{
			
		}
	}
}

