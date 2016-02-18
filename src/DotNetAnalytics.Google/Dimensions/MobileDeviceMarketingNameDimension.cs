namespace DotNetAnalytics.Google.Dimensions
{
    /// <summary>
    ///     The marketing name used for the mobile device.
    /// </summary>
    public class MobileDeviceMarketingNameDimension : Dimension<string>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="MobileDeviceMarketingNameDimension" />.
        /// </summary>
        public MobileDeviceMarketingNameDimension()
            : base(
                "Mobile Device Marketing Name", "The marketing name used for the mobile device.", true,
                "ga:mobileDeviceMarketingName")
        {
        }
    }
}