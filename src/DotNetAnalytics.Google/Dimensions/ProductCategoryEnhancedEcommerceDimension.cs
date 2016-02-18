namespace DotNetAnalytics.Google.Dimensions
{
    /// <summary>
    ///     The hierarchical category in which the product is classified (Enhanced Ecommerce).
    /// </summary>
    public class ProductCategoryEnhancedEcommerceDimension : Dimension<string>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="ProductCategoryEnhancedEcommerceDimension" />.
        /// </summary>
        public ProductCategoryEnhancedEcommerceDimension()
            : base(
                "Product Category (Enhanced Ecommerce)",
                "The hierarchical category in which the product is classified (Enhanced Ecommerce).", true,
                "ga:productCategoryHierarchy")
        {
        }
    }
}