namespace LinqAn.Google.Dimensions
{
    /// <summary>
    ///     For a social data hub activity, this value represents the URL of the photo associated with the user's social
    ///     network profile.
    /// </summary>
    public class UserPhotoURL : Dimension<string>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="UserPhotoURL" />.
        /// </summary>
        public UserPhotoURL()
            : base(
                "User Photo URL",
                "For a social data hub activity, this value represents the URL of the photo associated with the user's social network profile.",
                false, "ga:socialActivityUserPhotoUrl")
        {
        }
    }
}