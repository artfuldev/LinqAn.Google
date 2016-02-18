namespace DotNetAnalytics.Google.Dimensions
{
    /// <summary>
    ///     The type of device: desktop, tablet, or mobile.
    /// </summary>
    public class DeviceCategoryDimension : Dimension<string>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="DeviceCategoryDimension" />.
        /// </summary>
        public DeviceCategoryDimension()
            : base("Device Category", "The type of device: desktop, tablet, or mobile.", true, "ga:deviceCategory")
        {
        }
    }
}