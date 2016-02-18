namespace DotNetAnalytics.Google.Dimensions
{
    /// <summary>
    ///     Engagement type. Possible values are "Socially Engaged" or "Not Socially Engaged".
    /// </summary>
    public class SocialTypeDimension : Dimension<string>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="SocialTypeDimension" />.
        /// </summary>
        public SocialTypeDimension()
            : base(
                "Social Type", "Engagement type. Possible values are \"Socially Engaged\" or \"Not Socially Engaged\".",
                false, "ga:socialEngagementType")
        {
        }
    }
}