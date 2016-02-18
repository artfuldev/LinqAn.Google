namespace DotNetAnalytics.Google.Metrics
{
	/// <summary>
	/// 	Quantity of the product being queried.
	/// </summary>
	public class QueriedProductQuantityMetric: Metric<int>
	{
		/// <summary>
	/// 	Instantiates a <seealso cref="QueriedProductQuantityMetric" />.
		/// </summary>
		public QueriedProductQuantityMetric(): base("Queried Product Quantity","Quantity of the product being queried.",false,"ga:queryProductQuantity")
		{
			
		}
	}
}

