namespace DotNetAnalytics.Google.Dimensions
{
    /// <summary>
    ///     For a social data hub activity, this is a comma-separated set of tags associated with the social activity.
    /// </summary>
    public class SocialTagsSummaryDimension : Dimension<string>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="SocialTagsSummaryDimension" />.
        /// </summary>
        public SocialTagsSummaryDimension()
            : base(
                "Social Tags Summary",
                "For a social data hub activity, this is a comma-separated set of tags associated with the social activity.",
                false, "ga:socialActivityTagsSummary")
        {
        }
    }
}