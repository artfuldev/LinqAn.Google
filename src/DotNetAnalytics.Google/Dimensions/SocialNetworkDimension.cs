namespace DotNetAnalytics.Google.Dimensions
{
    /// <summary>
    ///     For social interactions, a value representing the social network being tracked.
    /// </summary>
    public class SocialNetworkDimension : Dimension<string>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="SocialNetworkDimension" />.
        /// </summary>
        public SocialNetworkDimension()
            : base(
                "Social Network", "For social interactions, a value representing the social network being tracked.",
                false, "ga:socialInteractionNetwork")
        {
        }
    }
}