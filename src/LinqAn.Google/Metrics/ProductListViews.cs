namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	Number of times the product appeared in a product list (Enhanced Ecommerce).
	/// </summary>
	public class ProductListViews: Metric<int>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="ProductListViews" />.
		/// </summary>
		public ProductListViews(): base("Product List Views","Number of times the product appeared in a product list (Enhanced Ecommerce).",true,"ga:productListViews")
		{
			
		}
	}
}

