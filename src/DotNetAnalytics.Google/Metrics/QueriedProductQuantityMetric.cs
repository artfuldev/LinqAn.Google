namespace DotNetAnalytics.Google.Metrics
{
	public class QueriedProductQuantityMetric: Metric<int>
	{
		/// <summary>
		/// 	Quantity of the product being queried.
		/// </summary>
		public QueriedProductQuantityMetric(): base("Queried Product Quantity","Quantity of the product being queried.",false,"ga:queryProductQuantity")
		{
			
		}
	}
}

