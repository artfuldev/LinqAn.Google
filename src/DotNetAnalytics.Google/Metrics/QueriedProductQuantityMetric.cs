namespace DotNetAnalytics.Google.Metrics
{
	public class QueriedProductQuantityMetric: Metric<int>
	{
		public QueriedProductQuantityMetric(): base("Queried Product Quantity","Quantity of the product being queried.",false,"ga:queryProductQuantity")
		{
			
		}
	}
}

