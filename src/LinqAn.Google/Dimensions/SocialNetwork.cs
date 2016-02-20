namespace LinqAn.Google.Dimensions
{
    /// <summary>
    ///     For social interactions, a value representing the social network being tracked.
    /// </summary>
    public class SocialNetwork : Dimension<string>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="SocialNetwork" />.
        /// </summary>
        public SocialNetwork()
            : base(
                "Social Network", "For social interactions, a value representing the social network being tracked.",
                false, "ga:socialInteractionNetwork")
        {
        }
    }
}