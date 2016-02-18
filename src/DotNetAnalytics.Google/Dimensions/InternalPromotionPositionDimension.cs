namespace DotNetAnalytics.Google.Dimensions
{
    /// <summary>
    ///     The position of the promotion on the web page or application screen (Enhanced Ecommerce).
    /// </summary>
    public class InternalPromotionPositionDimension : Dimension<string>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="InternalPromotionPositionDimension" />.
        /// </summary>
        public InternalPromotionPositionDimension()
            : base(
                "Internal Promotion Position",
                "The position of the promotion on the web page or application screen (Enhanced Ecommerce).", true,
                "ga:internalPromotionPosition")
        {
        }
    }
}