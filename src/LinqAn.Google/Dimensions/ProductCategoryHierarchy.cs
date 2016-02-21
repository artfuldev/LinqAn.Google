namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The hierarchical category in which the product is classified (Enhanced Ecommerce).
	/// </summary>
	public class ProductCategoryHierarchy: Dimension<string>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="ProductCategoryHierarchy" />.
		/// </summary>
		public ProductCategoryHierarchy(): base("Product Category (Enhanced Ecommerce)","The hierarchical category in which the product is classified (Enhanced Ecommerce).",true,"ga:productCategoryHierarchy")
		{
			
		}
	}
}

