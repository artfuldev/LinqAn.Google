namespace DotNetAnalytics.Google.Metrics
{
	/// <summary>
	/// 	The total amount of tax.
	/// </summary>
	public class TaxMetric: Metric<decimal>
	{
		/// <summary>
	/// 	Instantiates a <seealso cref="TaxMetric" />.
		/// </summary>
		public TaxMetric(): base("Tax","The total amount of tax.",true,"ga:transactionTax")
		{
			
		}
	}
}

