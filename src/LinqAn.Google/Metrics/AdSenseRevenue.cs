namespace LinqAn.Google.Metrics
{
    /// <summary>
    ///     The total revenue from AdSense ads.
    /// </summary>
    public class AdSenseRevenue : Metric<decimal>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="AdSenseRevenue" />.
        /// </summary>
        public AdSenseRevenue()
            : base("AdSense Revenue", "The total revenue from AdSense ads.", true, "ga:adsenseRevenue")
        {
        }
    }
}