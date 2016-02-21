namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	Number of times users clicked the product when it appeared in the product list (Enhanced Ecommerce).
	/// </summary>
	public class ProductListClicks: Metric<int>
	{
		/// <summary>
	/// 	Instantiates a <seealso cref="ProductListClicks" />.
		/// </summary>
		public ProductListClicks(): base("Product List Clicks","Number of times users clicked the product when it appeared in the product list (Enhanced Ecommerce).",true,"ga:productListClicks")
		{
			
		}
	}
}

