namespace LinqAn.Google.Dimensions
{
    /// <summary>
    ///     Correlation Model ID for related products.
    /// </summary>
    public class CorrelationModelID : Dimension<string>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="CorrelationModelID" />.
        /// </summary>
        public CorrelationModelID()
            : base("Correlation Model ID", "Correlation Model ID for related products.", false, "ga:correlationModelId")
        {
        }
    }
}