namespace LinqAn.Google.Metrics
{
    /// <summary>
    ///     The total amount of tax.
    /// </summary>
    public class Tax : Metric<decimal>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="Tax" />.
        /// </summary>
        public Tax() : base("Tax", "The total amount of tax.", true, "ga:transactionTax")
        {
        }
    }
}