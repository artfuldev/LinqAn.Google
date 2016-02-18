namespace DotNetAnalytics.Google.Dimensions
{
    /// <summary>
    ///     For social interactions, a value representing the social action being tracked (e.g. +1, bookmark)
    /// </summary>
    public class SocialActionDimension : Dimension<string>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="SocialActionDimension" />.
        /// </summary>
        public SocialActionDimension()
            : base(
                "Social Action",
                "For social interactions, a value representing the social action being tracked (e.g. +1, bookmark)",
                false, "ga:socialInteractionAction")
        {
        }
    }
}