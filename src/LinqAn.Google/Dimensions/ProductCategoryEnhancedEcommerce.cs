namespace LinqAn.Google.Dimensions
{
    /// <summary>
    ///     The hierarchical category in which the product is classified (Enhanced Ecommerce).
    /// </summary>
    public class ProductCategoryEnhancedEcommerce : Dimension<string>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="ProductCategoryEnhancedEcommerce" />.
        /// </summary>
        public ProductCategoryEnhancedEcommerce()
            : base(
                "Product Category (Enhanced Ecommerce)",
                "The hierarchical category in which the product is classified (Enhanced Ecommerce).", true,
                "ga:productCategoryHierarchy")
        {
        }
    }
}