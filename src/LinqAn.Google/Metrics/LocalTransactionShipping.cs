namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	Transaction shipping cost in local currency.
	/// </summary>
	public class LocalTransactionShipping: Metric<decimal>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="LocalTransactionShipping" />.
		/// </summary>
		public LocalTransactionShipping(): base("Local Shipping","Transaction shipping cost in local currency.",false,"ga:localTransactionShipping")
		{
			
		}
	}
}

