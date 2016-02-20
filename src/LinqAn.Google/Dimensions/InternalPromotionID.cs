namespace LinqAn.Google.Dimensions
{
    /// <summary>
    ///     The ID of the promotion (Enhanced Ecommerce).
    /// </summary>
    public class InternalPromotionID : Dimension<string>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="InternalPromotionID" />.
        /// </summary>
        public InternalPromotionID()
            : base(
                "Internal Promotion ID", "The ID of the promotion (Enhanced Ecommerce).", true, "ga:internalPromotionId"
                )
        {
        }
    }
}