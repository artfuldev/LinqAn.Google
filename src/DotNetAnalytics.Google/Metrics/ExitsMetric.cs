namespace DotNetAnalytics.Google.Metrics
{
    /// <summary>
    ///     The number of exits from your property.
    /// </summary>
    public class ExitsMetric : Metric<int>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="ExitsMetric" />.
        /// </summary>
        public ExitsMetric() : base("Exits", "The number of exits from your property.", true, "ga:exits")
        {
        }
    }
}