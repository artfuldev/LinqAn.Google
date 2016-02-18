namespace DotNetAnalytics.Google.Dimensions
{
    /// <summary>
    ///     The number of screenviews per session reported as a string. Can be useful for historgrams.
    /// </summary>
    public class ScreenDepthDimension : Dimension<string>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="ScreenDepthDimension" />.
        /// </summary>
        public ScreenDepthDimension()
            : base(
                "Screen Depth",
                "The number of screenviews per session reported as a string. Can be useful for historgrams.", true,
                "ga:screenDepth")
        {
        }
    }
}