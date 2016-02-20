namespace LinqAn.Google.Metrics
{
    /// <summary>
    ///     The total number of activities where a content URL was shared / mentioned on a social data hub partner network.
    /// </summary>
    public class DataHubActivities : Metric<int>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="DataHubActivities" />.
        /// </summary>
        public DataHubActivities()
            : base(
                "Data Hub Activities",
                "The total number of activities where a content URL was shared / mentioned on a social data hub partner network.",
                false, "ga:socialActivities")
        {
        }
    }
}