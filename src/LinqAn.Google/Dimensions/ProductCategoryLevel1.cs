using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	Level (1-5) in the product category hierarchy, starting from the top (Enhanced Ecommerce).
	/// </summary>
	[Description("Level (1-5) in the product category hierarchy, starting from the top (Enhanced Ecommerce).")]
	public class ProductCategoryLevel1: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="ProductCategoryLevel1" />.
		/// </summary>
		public ProductCategoryLevel1(): base("Product Category Level 1",true,"ga:productCategoryLevel1")
		{
			
		}
	}
}

