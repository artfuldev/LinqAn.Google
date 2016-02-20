namespace LinqAn.Google.Metrics
{
    /// <summary>
    ///     The number of times AdX ads were clicked on your site.
    /// </summary>
    public class AdXClicks : Metric<int>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="AdXClicks" />.
        /// </summary>
        public AdXClicks()
            : base("AdX Clicks", "The number of times AdX ads were clicked on your site.", true, "ga:adxClicks")
        {
        }
    }
}