namespace LinqAn.Google.Dimensions
{
    /// <summary>
    ///     For a social data hub activity, this value represents the social network handle (e.g. name or ID) of the user who
    ///     initiated the social activity.
    /// </summary>
    public class SocialUserHandle : Dimension<string>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="SocialUserHandle" />.
        /// </summary>
        public SocialUserHandle()
            : base(
                "Social User Handle",
                "For a social data hub activity, this value represents the social network handle (e.g. name or ID) of the user who initiated the social activity.",
                false, "ga:socialActivityUserHandle")
        {
        }
    }
}