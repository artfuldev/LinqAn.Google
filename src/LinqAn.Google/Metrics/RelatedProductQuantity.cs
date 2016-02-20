namespace LinqAn.Google.Metrics
{
    /// <summary>
    ///     Quantity of the related product.
    /// </summary>
    public class RelatedProductQuantity : Metric<int>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="RelatedProductQuantity" />.
        /// </summary>
        public RelatedProductQuantity()
            : base("Related Product Quantity", "Quantity of the related product.", false, "ga:relatedProductQuantity")
        {
        }
    }
}