using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	Level (1-5) in the product category hierarchy, starting from the top (Enhanced Ecommerce).
	/// </summary>
	[Description("Level (1-5) in the product category hierarchy, starting from the top (Enhanced Ecommerce).")]
	public class ProductCategoryLevel3: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="ProductCategoryLevel3" />.
		/// </summary>
		public ProductCategoryLevel3(): base("Product Category Level 3",true,"ga:productCategoryLevel3")
		{
			
		}
	}
}

