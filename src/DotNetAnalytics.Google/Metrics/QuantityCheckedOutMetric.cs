namespace DotNetAnalytics.Google.Metrics
{
	public class QuantityCheckedOutMetric: Metric<int>
	{
		public QuantityCheckedOutMetric(): base("Quantity Checked Out","Number of product units included in check out (Enhanced Ecommerce).",true,"ga:quantityCheckedOut")
		{
			
		}
	}
}

