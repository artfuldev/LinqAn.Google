namespace LinqAn.Google.Metrics
{
    /// <summary>
    ///     Coverage is the percentage of ad requests that returned at least one ad. Generally, coverage can help you identify
    ///     sites where your AdX account isn't able to provide targeted ads. (Ad Impressions / Total Ad Requests) * 100
    /// </summary>
    public class AdXCoverage : Metric<float>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="AdXCoverage" />.
        /// </summary>
        public AdXCoverage()
            : base(
                "AdX Coverage",
                "Coverage is the percentage of ad requests that returned at least one ad. Generally, coverage can help you identify sites where your AdX account isn't able to provide targeted ads. (Ad Impressions / Total Ad Requests) * 100",
                false, "ga:adxCoverage")
        {
        }
    }
}