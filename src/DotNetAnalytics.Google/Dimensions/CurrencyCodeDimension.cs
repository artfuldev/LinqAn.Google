namespace DotNetAnalytics.Google.Dimensions
{
    /// <summary>
    ///     The local currency code of the transaction based on ISO 4217 standard.
    /// </summary>
    public class CurrencyCodeDimension : Dimension<string>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="CurrencyCodeDimension" />.
        /// </summary>
        public CurrencyCodeDimension()
            : base(
                "Currency Code", "The local currency code of the transaction based on ISO 4217 standard.", false,
                "ga:currencyCode")
        {
        }
    }
}