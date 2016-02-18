namespace DotNetAnalytics.Google.Dimensions
{
    /// <summary>
    ///     The operating system used by your users. For example, Windows, Linux , Macintosh, iPhone, iPod.
    /// </summary>
    public class OperatingSystemDimension : Dimension<string>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="OperatingSystemDimension" />.
        /// </summary>
        public OperatingSystemDimension()
            : base(
                "Operating System",
                "The operating system used by your users. For example, Windows, Linux , Macintosh, iPhone, iPod.", true,
                "ga:operatingSystem")
        {
        }
    }
}