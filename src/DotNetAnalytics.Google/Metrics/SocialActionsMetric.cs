namespace DotNetAnalytics.Google.Metrics
{
    /// <summary>
    ///     The total number of social interactions.
    /// </summary>
    public class SocialActionsMetric : Metric<int>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="SocialActionsMetric" />.
        /// </summary>
        public SocialActionsMetric()
            : base("Social Actions", "The total number of social interactions.", false, "ga:socialInteractions")
        {
        }
    }
}