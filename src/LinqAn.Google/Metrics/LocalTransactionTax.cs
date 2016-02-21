namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	Transaction tax in local currency.
	/// </summary>
	public class LocalTransactionTax: Metric<decimal>
	{
		/// <summary>
	/// 	Instantiates a <seealso cref="LocalTransactionTax" />.
		/// </summary>
		public LocalTransactionTax(): base("Local Tax","Transaction tax in local currency.",false,"ga:localTransactionTax")
		{
			
		}
	}
}

