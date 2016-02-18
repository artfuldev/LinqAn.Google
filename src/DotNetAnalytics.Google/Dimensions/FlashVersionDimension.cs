namespace DotNetAnalytics.Google.Dimensions
{
    /// <summary>
    ///     The versions of Flash supported by users' browsers, including minor versions.
    /// </summary>
    public class FlashVersionDimension : Dimension<string>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="FlashVersionDimension" />.
        /// </summary>
        public FlashVersionDimension()
            : base(
                "Flash Version", "The versions of Flash supported by users' browsers, including minor versions.", true,
                "ga:flashVersion")
        {
        }
    }
}