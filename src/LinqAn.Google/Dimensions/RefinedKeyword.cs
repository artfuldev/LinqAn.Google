namespace LinqAn.Google.Dimensions
{
    /// <summary>
    ///     Subsequent keyword search terms or strings entered by users after a given initial string search.
    /// </summary>
    public class RefinedKeyword : Dimension<string>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="RefinedKeyword" />.
        /// </summary>
        public RefinedKeyword()
            : base(
                "Refined Keyword",
                "Subsequent keyword search terms or strings entered by users after a given initial string search.", true,
                "ga:searchKeywordRefinement")
        {
        }
    }
}