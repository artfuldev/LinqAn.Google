namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	Number of refunds that have been issued (Enhanced Ecommerce).
	/// </summary>
	public class TotalRefunds: Metric<int>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="TotalRefunds" />.
		/// </summary>
		public TotalRefunds(): base("Refunds","Number of refunds that have been issued (Enhanced Ecommerce).",true,"ga:totalRefunds")
		{
			
		}
	}
}

