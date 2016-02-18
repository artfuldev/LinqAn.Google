namespace DotNetAnalytics.Google.Dimensions
{
    /// <summary>
    ///     The branding, model, and marketing name used to identify the mobile device.
    /// </summary>
    public class MobileDeviceInfoDimension : Dimension<string>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="MobileDeviceInfoDimension" />.
        /// </summary>
        public MobileDeviceInfoDimension()
            : base(
                "Mobile Device Info", "The branding, model, and marketing name used to identify the mobile device.",
                true, "ga:mobileDeviceInfo")
        {
        }
    }
}