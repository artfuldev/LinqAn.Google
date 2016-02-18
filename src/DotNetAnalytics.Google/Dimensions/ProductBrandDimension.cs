namespace DotNetAnalytics.Google.Dimensions
{
	/// <summary>
	/// 	The brand name under which the product is sold (Enhanced Ecommerce).
	/// </summary>
	public class ProductBrandDimension: Dimension<string>
	{
		/// <summary>
	/// 	Instantiates a <seealso cref="ProductBrandDimension" />.
		/// </summary>
		public ProductBrandDimension(): base("Product Brand","The brand name under which the product is sold (Enhanced Ecommerce).",true,"ga:productBrand")
		{
			
		}
	}
}

