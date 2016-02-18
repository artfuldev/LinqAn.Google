namespace DotNetAnalytics.Google.Metrics
{
	/// <summary>
	/// 	Quantity of the related product.
	/// </summary>
	public class RelatedProductQuantityMetric: Metric<int>
	{
		/// <summary>
	/// 	Instantiates a <seealso cref="RelatedProductQuantityMetric" />.
		/// </summary>
		public RelatedProductQuantityMetric(): base("Related Product Quantity","Quantity of the related product.",false,"ga:relatedProductQuantity")
		{
			
		}
	}
}

