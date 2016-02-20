namespace LinqAn.Google.Metrics
{
    /// <summary>
    ///     The percentage of pageviews that resulted in a click on an AdX ad.
    /// </summary>
    public class AdXCTR : Metric<float>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="AdXCTR" />.
        /// </summary>
        public AdXCTR()
            : base("AdX CTR", "The percentage of pageviews that resulted in a click on an AdX ad.", false, "ga:adxCTR")
        {
        }
    }
}