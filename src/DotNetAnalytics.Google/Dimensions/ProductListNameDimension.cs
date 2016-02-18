namespace DotNetAnalytics.Google.Dimensions
{
	public class ProductListNameDimension: Dimension<string>
	{
		/// <summary>
		/// 	The name of the product list in which the product appears (Enhanced Ecommerce).
		/// </summary>
		public ProductListNameDimension(): base("Product List Name","The name of the product list in which the product appears (Enhanced Ecommerce).",true,"ga:productListName")
		{
			
		}
	}
}

