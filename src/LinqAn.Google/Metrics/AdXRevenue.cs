namespace LinqAn.Google.Metrics
{
    /// <summary>
    ///     The total estimated revenue from AdX ads.
    /// </summary>
    public class AdXRevenue : Metric<decimal>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="AdXRevenue" />.
        /// </summary>
        public AdXRevenue() : base("AdX Revenue", "The total estimated revenue from AdX ads.", true, "ga:adxRevenue")
        {
        }
    }
}