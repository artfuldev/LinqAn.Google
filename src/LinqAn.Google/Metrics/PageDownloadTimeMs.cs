namespace LinqAn.Google.Metrics
{
    /// <summary>
    ///     The total amount of time (in milliseconds) to download this page among all samples.
    /// </summary>
    public class PageDownloadTimeMs : Metric<int>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="PageDownloadTimeMs" />.
        /// </summary>
        public PageDownloadTimeMs()
            : base(
                "Page Download Time (ms)",
                "The total amount of time (in milliseconds) to download this page among all samples.", false,
                "ga:pageDownloadTime")
        {
        }
    }
}