namespace DotNetAnalytics.Google.Metrics
{
    /// <summary>
    ///     The number of sessions that ended due to a user clicking on an AdSense ad.
    /// </summary>
    public class AdSenseExitsMetric : Metric<int>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="AdSenseExitsMetric" />.
        /// </summary>
        public AdSenseExitsMetric()
            : base(
                "AdSense Exits", "The number of sessions that ended due to a user clicking on an AdSense ad.", true,
                "ga:adsenseExits")
        {
        }
    }
}