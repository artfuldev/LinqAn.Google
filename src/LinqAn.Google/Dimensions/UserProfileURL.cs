namespace LinqAn.Google.Dimensions
{
    /// <summary>
    ///     For a social data hub activity, this value represents the URL of the associated user's social network profile.
    /// </summary>
    public class UserProfileURL : Dimension<string>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="UserProfileURL" />.
        /// </summary>
        public UserProfileURL()
            : base(
                "User Profile URL",
                "For a social data hub activity, this value represents the URL of the associated user's social network profile.",
                false, "ga:socialActivityUserProfileUrl")
        {
        }
    }
}