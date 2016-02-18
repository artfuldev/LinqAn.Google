namespace DotNetAnalytics.Google.Metrics
{
	public class TaxMetric: Metric<decimal>
	{
		/// <summary>
		/// 	The total amount of tax.
		/// </summary>
		public TaxMetric(): base("Tax","The total amount of tax.",true,"ga:transactionTax")
		{
			
		}
	}
}

