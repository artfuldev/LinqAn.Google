using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The hierarchical category in which the product is classified (Enhanced Ecommerce).
	/// </summary>
	[Description("The hierarchical category in which the product is classified (Enhanced Ecommerce).")]
	public class ProductCategoryHierarchy: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="ProductCategoryHierarchy" />.
		/// </summary>
		public ProductCategoryHierarchy(): base("Product Category (Enhanced Ecommerce)",true,"ga:productCategoryHierarchy")
		{
			
		}
	}
}

