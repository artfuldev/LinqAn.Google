namespace DotNetAnalytics.Google.Dimensions
{
	/// <summary>
	/// 	The position of the product in the product list (Enhanced Ecommerce).
	/// </summary>
	public class ProductListPositionDimension: Dimension<string>
	{
		/// <summary>
	/// 	Instantiates a <seealso cref="ProductListPositionDimension" />.
		/// </summary>
		public ProductListPositionDimension(): base("Product List Position","The position of the product in the product list (Enhanced Ecommerce).",true,"ga:productListPosition")
		{
			
		}
	}
}

