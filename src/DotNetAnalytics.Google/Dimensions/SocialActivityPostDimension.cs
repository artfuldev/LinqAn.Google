namespace DotNetAnalytics.Google.Dimensions
{
    /// <summary>
    ///     For a social data hub activity, this value represents the content of the social activity posted by the social
    ///     network user (e.g. The message content of a Google+ post)
    /// </summary>
    public class SocialActivityPostDimension : Dimension<string>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="SocialActivityPostDimension" />.
        /// </summary>
        public SocialActivityPostDimension()
            : base(
                "Social Activity Post",
                "For a social data hub activity, this value represents the content of the social activity posted by the social network user (e.g. The message content of a Google+ post)",
                false, "ga:socialActivityPost")
        {
        }
    }
}