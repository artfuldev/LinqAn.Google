namespace DotNetAnalytics.Google.Dimensions
{
    /// <summary>
    ///     The location of the advertisement on the hosting page (Top, RHS, or not set).
    /// </summary>
    public class AdSlotDimension : Dimension<string>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="AdSlotDimension" />.
        /// </summary>
        public AdSlotDimension()
            : base(
                "Ad Slot", "The location of the advertisement on the hosting page (Top, RHS, or not set).", true,
                "ga:adSlot")
        {
        }
    }
}