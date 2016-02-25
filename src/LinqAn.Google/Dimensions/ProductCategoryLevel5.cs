using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	Level (1-5) in the product category hierarchy, starting from the top (Enhanced Ecommerce).
	/// </summary>
	[Description("Level (1-5) in the product category hierarchy, starting from the top (Enhanced Ecommerce).")]
	public class ProductCategoryLevel5: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="ProductCategoryLevel5" />.
		/// </summary>
		public ProductCategoryLevel5(): base("Product Category Level 5",true,"ga:productCategoryLevel5")
		{
			
		}
	}
}

