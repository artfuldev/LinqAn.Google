namespace DotNetAnalytics.Google.Dimensions
{
	public class ProductBrandDimension: Dimension<string>
	{
		/// <summary>
		/// 	The brand name under which the product is sold (Enhanced Ecommerce).
		/// </summary>
		public ProductBrandDimension(): base("Product Brand","The brand name under which the product is sold (Enhanced Ecommerce).",true,"ga:productBrand")
		{
			
		}
	}
}

