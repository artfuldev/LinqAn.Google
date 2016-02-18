namespace DotNetAnalytics.Google.Dimensions
{
    /// <summary>
    ///     For a social data hub activity, this value represents the URL shared by the associated social network user.
    /// </summary>
    public class SharedURLDimension : Dimension<string>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="SharedURLDimension" />.
        /// </summary>
        public SharedURLDimension()
            : base(
                "Shared URL",
                "For a social data hub activity, this value represents the URL shared by the associated social network user.",
                false, "ga:socialActivityContentUrl")
        {
        }
    }
}