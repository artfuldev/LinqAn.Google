using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The specific variation of a product, e.g., XS, S, M, L for size or Red, Blue, Green, Black for color (Enhanced Ecommerce).
	/// </summary>
	[Description("The specific variation of a product, e.g., XS, S, M, L for size or Red, Blue, Green, Black for color (Enhanced Ecommerce).")]
	public class ProductVariant: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="ProductVariant" />.
		/// </summary>
		public ProductVariant(): base("Product Variant",true,"ga:productVariant")
		{
			
		}
	}
}

