namespace LinqAn.Google.Dimensions
{
    /// <summary>
    ///     For a social data hub activity, this value represents the URL of the social activity (e.g. the Google+ post URL,
    ///     the blog comment URL, etc.)
    /// </summary>
    public class EndorsingURL : Dimension<string>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="EndorsingURL" />.
        /// </summary>
        public EndorsingURL()
            : base(
                "Endorsing URL",
                "For a social data hub activity, this value represents the URL of the social activity (e.g. the Google+ post URL, the blog comment URL, etc.)",
                false, "ga:socialActivityEndorsingUrl")
        {
        }
    }
}