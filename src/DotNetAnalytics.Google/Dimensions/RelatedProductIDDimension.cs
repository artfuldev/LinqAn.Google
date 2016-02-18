namespace DotNetAnalytics.Google.Dimensions
{
    /// <summary>
    ///     ID of the related product.
    /// </summary>
    public class RelatedProductIDDimension : Dimension<string>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="RelatedProductIDDimension" />.
        /// </summary>
        public RelatedProductIDDimension()
            : base("Related Product ID", "ID of the related product.", false, "ga:relatedProductId")
        {
        }
    }
}