namespace DotNetAnalytics.Google.Metrics
{
	public class QuantityMetric: Metric<int>
	{
		public QuantityMetric(): base("Quantity","The total number of items purchased. For example, if users purchase 2 frisbees and 5 tennis balls, 7 items have been purchased.",true,"ga:itemQuantity")
		{
			
		}
	}
}

