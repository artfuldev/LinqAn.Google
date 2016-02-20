namespace LinqAn.Google.Dimensions
{
    /// <summary>
    ///     When using manual campaign tracking, the value of the utm_term campaign tracking parameter. When using AdWords
    ///     autotagging or if a user used organic search to reach your property, the keywords used by users to reach your
    ///     property. Otherwise the value is (not set).
    /// </summary>
    public class Keyword : Dimension<string>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="Keyword" />.
        /// </summary>
        public Keyword()
            : base(
                "Keyword",
                "When using manual campaign tracking, the value of the utm_term campaign tracking parameter. When using AdWords autotagging or if a user used organic search to reach your property, the keywords used by users to reach your property. Otherwise the value is (not set).",
                true, "ga:keyword")
        {
        }
    }
}