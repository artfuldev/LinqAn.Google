namespace DotNetAnalytics.Google.Dimensions
{
    /// <summary>
    ///     The creative content designed for a promotion (Enhanced Ecommerce).
    /// </summary>
    public class InternalPromotionCreativeDimension : Dimension<string>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="InternalPromotionCreativeDimension" />.
        /// </summary>
        public InternalPromotionCreativeDimension()
            : base(
                "Internal Promotion Creative", "The creative content designed for a promotion (Enhanced Ecommerce).",
                true, "ga:internalPromotionCreative")
        {
        }
    }
}