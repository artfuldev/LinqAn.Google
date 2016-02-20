namespace LinqAn.Google.Metrics
{
    /// <summary>
    ///     The percentage of ad impressions that were viewable. An impression is considered a viewable impression when it has
    ///     appeared within a user's browser and had the opportunity to be seen.
    /// </summary>
    public class AdXViewableImpressions : Metric<float>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="AdXViewableImpressions" />.
        /// </summary>
        public AdXViewableImpressions()
            : base(
                "AdX Viewable Impressions %",
                "The percentage of ad impressions that were viewable. An impression is considered a viewable impression when it has appeared within a user's browser and had the opportunity to be seen.",
                false, "ga:adxViewableImpressionsPercent")
        {
        }
    }
}