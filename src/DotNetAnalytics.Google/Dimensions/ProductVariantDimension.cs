namespace DotNetAnalytics.Google.Dimensions
{
	public class ProductVariantDimension: Dimension<string>
	{
		/// <summary>
		/// 	The specific variation of a product, e.g., XS, S, M, L for size or Red, Blue, Green, Black for color (Enhanced Ecommerce).
		/// </summary>
		public ProductVariantDimension(): base("Product Variant","The specific variation of a product, e.g., XS, S, M, L for size or Red, Blue, Green, Black for color (Enhanced Ecommerce).",true,"ga:productVariant")
		{
			
		}
	}
}

