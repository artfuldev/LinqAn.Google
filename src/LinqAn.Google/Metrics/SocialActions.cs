namespace LinqAn.Google.Metrics
{
    /// <summary>
    ///     The total number of social interactions.
    /// </summary>
    public class SocialActions : Metric<int>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="SocialActions" />.
        /// </summary>
        public SocialActions()
            : base("Social Actions", "The total number of social interactions.", false, "ga:socialInteractions")
        {
        }
    }
}