namespace DotNetAnalytics.Google.Metrics
{
	public class RelatedProductQuantityMetric: Metric<int>
	{
		/// <summary>
		/// 	Quantity of the related product.
		/// </summary>
		public RelatedProductQuantityMetric(): base("Related Product Quantity","Quantity of the related product.",false,"ga:relatedProductQuantity")
		{
			
		}
	}
}

