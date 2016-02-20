namespace LinqAn.Google.Metrics
{
    /// <summary>
    ///     Product revenue in local currency.
    /// </summary>
    public class LocalProductRevenue : Metric<decimal>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="LocalProductRevenue" />.
        /// </summary>
        public LocalProductRevenue()
            : base("Local Product Revenue", "Product revenue in local currency.", true, "ga:localItemRevenue")
        {
        }
    }
}