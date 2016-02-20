namespace LinqAn.Google.Metrics
{
    /// <summary>
    ///     The effective cost per thousand pageviews. It is your AdX Revenue per 1000 pageviews.
    /// </summary>
    public class AdXECPM : Metric<decimal>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="AdXECPM" />.
        /// </summary>
        public AdXECPM()
            : base(
                "AdX eCPM", "The effective cost per thousand pageviews. It is your AdX Revenue per 1000 pageviews.",
                false, "ga:adxECPM")
        {
        }
    }
}