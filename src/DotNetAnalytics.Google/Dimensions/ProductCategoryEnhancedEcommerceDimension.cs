namespace DotNetAnalytics.Google.Dimensions
{
	public class ProductCategoryEnhancedEcommerceDimension: Dimension<string>
	{
		/// <summary>
		/// 	The hierarchical category in which the product is classified (Enhanced Ecommerce).
		/// </summary>
		public ProductCategoryEnhancedEcommerceDimension(): base("Product Category (Enhanced Ecommerce)","The hierarchical category in which the product is classified (Enhanced Ecommerce).",true,"ga:productCategoryHierarchy")
		{
			
		}
	}
}

