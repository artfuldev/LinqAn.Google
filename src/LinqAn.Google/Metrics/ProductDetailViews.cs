namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	Number of times users viewed the product-detail page (Enhanced Ecommerce).
	/// </summary>
	public class ProductDetailViews: Metric<int>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="ProductDetailViews" />.
		/// </summary>
		public ProductDetailViews(): base("Product Detail Views","Number of times users viewed the product-detail page (Enhanced Ecommerce).",true,"ga:productDetailViews")
		{
			
		}
	}
}

