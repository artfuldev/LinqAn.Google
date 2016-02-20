namespace LinqAn.Google.Metrics
{
    /// <summary>
    ///     The number of sessions that ended due to a user clicking on an AdSense ad.
    /// </summary>
    public class AdSenseExits : Metric<int>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="AdSenseExits" />.
        /// </summary>
        public AdSenseExits()
            : base(
                "AdSense Exits", "The number of sessions that ended due to a user clicking on an AdSense ad.", true,
                "ga:adsenseExits")
        {
        }
    }
}