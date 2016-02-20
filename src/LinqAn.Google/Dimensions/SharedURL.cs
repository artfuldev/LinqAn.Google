namespace LinqAn.Google.Dimensions
{
    /// <summary>
    ///     For a social data hub activity, this value represents the URL shared by the associated social network user.
    /// </summary>
    public class SharedURL : Dimension<string>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="SharedURL" />.
        /// </summary>
        public SharedURL()
            : base(
                "Shared URL",
                "For a social data hub activity, this value represents the URL shared by the associated social network user.",
                false, "ga:socialActivityContentUrl")
        {
        }
    }
}