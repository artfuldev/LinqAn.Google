namespace DotNetAnalytics.Google.Dimensions
{
	/// <summary>
	/// 	The specific variation of a product, e.g., XS, S, M, L for size or Red, Blue, Green, Black for color (Enhanced Ecommerce).
	/// </summary>
	public class ProductVariantDimension: Dimension<string>
	{
		/// <summary>
	/// 	Instantiates a <seealso cref="ProductVariantDimension" />.
		/// </summary>
		public ProductVariantDimension(): base("Product Variant","The specific variation of a product, e.g., XS, S, M, L for size or Red, Blue, Green, Black for color (Enhanced Ecommerce).",true,"ga:productVariant")
		{
			
		}
	}
}

