using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	Level (1-5) in the product category hierarchy, starting from the top (Enhanced Ecommerce).
	/// </summary>
	[Description("Level (1-5) in the product category hierarchy, starting from the top (Enhanced Ecommerce).")]
	public class ProductCategoryLevel2: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="ProductCategoryLevel2" />.
		/// </summary>
		public ProductCategoryLevel2(): base("Product Category Level 2",true,"ga:productCategoryLevel2")
		{
			
		}
	}
}

