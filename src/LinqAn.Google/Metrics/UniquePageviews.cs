namespace LinqAn.Google.Metrics
{
    /// <summary>
    ///     The number of unique page views. Page views within different sessions count as separate unique page views. This
    ///     takes into account both the pagePath and pageTitle to determine uniqueness.
    /// </summary>
    public class UniquePageviews : Metric<int>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="UniquePageviews" />.
        /// </summary>
        public UniquePageviews()
            : base(
                "Unique Pageviews",
                "The number of unique page views. Page views within different sessions count as separate unique page views. This takes into account both the pagePath and pageTitle to determine uniqueness.",
                true, "ga:uniquePageviews")
        {
        }
    }
}