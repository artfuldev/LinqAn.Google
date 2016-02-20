namespace LinqAn.Google.Metrics
{
    /// <summary>
    ///     The percentage of ad requests that returned at least one ad.
    /// </summary>
    public class AdSenseCoverage : Metric<float>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="AdSenseCoverage" />.
        /// </summary>
        public AdSenseCoverage()
            : base(
                "AdSense Coverage", "The percentage of ad requests that returned at least one ad.", false,
                "ga:adsenseCoverage")
        {
        }
    }
}