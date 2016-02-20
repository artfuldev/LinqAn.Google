namespace LinqAn.Google.Dimensions
{
    /// <summary>
    ///     ID of the related product.
    /// </summary>
    public class RelatedProductID : Dimension<string>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="RelatedProductID" />.
        /// </summary>
        public RelatedProductID()
            : base("Related Product ID", "ID of the related product.", false, "ga:relatedProductId")
        {
        }
    }
}