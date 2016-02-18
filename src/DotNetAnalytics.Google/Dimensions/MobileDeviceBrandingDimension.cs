namespace DotNetAnalytics.Google.Dimensions
{
    /// <summary>
    ///     Mobile manufacturer or branded name.
    /// </summary>
    public class MobileDeviceBrandingDimension : Dimension<string>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="MobileDeviceBrandingDimension" />.
        /// </summary>
        public MobileDeviceBrandingDimension()
            : base("Mobile Device Branding", "Mobile manufacturer or branded name.", true, "ga:mobileDeviceBranding")
        {
        }
    }
}