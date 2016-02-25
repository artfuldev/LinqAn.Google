using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	Level (1-5) in the product category hierarchy, starting from the top (Enhanced Ecommerce).
	/// </summary>
	[Description("Level (1-5) in the product category hierarchy, starting from the top (Enhanced Ecommerce).")]
	public class ProductCategoryLevel4: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="ProductCategoryLevel4" />.
		/// </summary>
		public ProductCategoryLevel4(): base("Product Category Level 4",true,"ga:productCategoryLevel4")
		{
			
		}
	}
}

