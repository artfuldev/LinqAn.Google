namespace LinqAn.Google.Dimensions
{
    /// <summary>
    ///     Variation of the product being queried.
    /// </summary>
    public class QueriedProductVariation : Dimension<string>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="QueriedProductVariation" />.
        /// </summary>
        public QueriedProductVariation()
            : base(
                "Queried Product Variation", "Variation of the product being queried.", false,
                "ga:queryProductVariation")
        {
        }
    }
}