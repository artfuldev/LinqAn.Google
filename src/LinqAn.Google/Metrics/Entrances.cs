namespace LinqAn.Google.Metrics
{
    /// <summary>
    ///     The number of entrances to your property measured as the first pageview in a session. Typically used with
    ///     landingPagePath
    /// </summary>
    public class Entrances : Metric<int>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="Entrances" />.
        /// </summary>
        public Entrances()
            : base(
                "Entrances",
                "The number of entrances to your property measured as the first pageview in a session. Typically used with landingPagePath",
                true, "ga:entrances")
        {
        }
    }
}