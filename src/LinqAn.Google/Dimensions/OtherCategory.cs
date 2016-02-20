namespace LinqAn.Google.Dimensions
{
    /// <summary>
    ///     Indicates that users are more likely to be interested in learning about the specified category, and more likely to
    ///     be ready to purchase.
    /// </summary>
    public class OtherCategory : Dimension<string>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="OtherCategory" />.
        /// </summary>
        public OtherCategory()
            : base(
                "Other Category",
                "Indicates that users are more likely to be interested in learning about the specified category, and more likely to be ready to purchase.",
                false, "ga:interestOtherCategory")
        {
        }
    }
}