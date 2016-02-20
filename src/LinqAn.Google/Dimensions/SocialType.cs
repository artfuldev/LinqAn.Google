namespace LinqAn.Google.Dimensions
{
    /// <summary>
    ///     Engagement type. Possible values are "Socially Engaged" or "Not Socially Engaged".
    /// </summary>
    public class SocialType : Dimension<string>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="SocialType" />.
        /// </summary>
        public SocialType()
            : base(
                "Social Type", "Engagement type. Possible values are \"Socially Engaged\" or \"Not Socially Engaged\".",
                false, "ga:socialEngagementType")
        {
        }
    }
}