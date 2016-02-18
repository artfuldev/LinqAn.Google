namespace DotNetAnalytics.Google.Dimensions
{
    /// <summary>
    ///     Mobile device model.
    /// </summary>
    public class MobileDeviceModelDimension : Dimension<string>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="MobileDeviceModelDimension" />.
        /// </summary>
        public MobileDeviceModelDimension()
            : base("Mobile Device Model", "Mobile device model.", true, "ga:mobileDeviceModel")
        {
        }
    }
}