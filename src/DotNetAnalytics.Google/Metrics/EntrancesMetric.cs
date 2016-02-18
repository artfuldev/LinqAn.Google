namespace DotNetAnalytics.Google.Metrics
{
    /// <summary>
    ///     The number of entrances to your property measured as the first pageview in a session. Typically used with
    ///     landingPagePath
    /// </summary>
    public class EntrancesMetric : Metric<int>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="EntrancesMetric" />.
        /// </summary>
        public EntrancesMetric()
            : base(
                "Entrances",
                "The number of entrances to your property measured as the first pageview in a session. Typically used with landingPagePath",
                true, "ga:entrances")
        {
        }
    }
}