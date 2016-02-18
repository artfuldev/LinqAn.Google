namespace DotNetAnalytics.Google.Dimensions
{
    /// <summary>
    ///     Indicates sessions that arrived to the property from a social source. The possible values are Yes or No where the
    ///     first letter is capitalized.
    /// </summary>
    public class SocialSourceReferralDimension : Dimension<string>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="SocialSourceReferralDimension" />.
        /// </summary>
        public SocialSourceReferralDimension()
            : base(
                "Social Source Referral",
                "Indicates sessions that arrived to the property from a social source. The possible values are Yes or No where the first letter is capitalized.",
                false, "ga:hasSocialSourceReferral")
        {
        }
    }
}