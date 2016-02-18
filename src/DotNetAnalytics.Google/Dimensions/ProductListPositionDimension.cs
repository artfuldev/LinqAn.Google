namespace DotNetAnalytics.Google.Dimensions
{
	public class ProductListPositionDimension: Dimension<string>
	{
		/// <summary>
		/// 	The position of the product in the product list (Enhanced Ecommerce).
		/// </summary>
		public ProductListPositionDimension(): base("Product List Position","The position of the product in the product list (Enhanced Ecommerce).",true,"ga:productListPosition")
		{
			
		}
	}
}

