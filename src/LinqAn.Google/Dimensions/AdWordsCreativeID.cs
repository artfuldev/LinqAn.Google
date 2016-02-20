namespace LinqAn.Google.Dimensions
{
    /// <summary>
    ///     A string. Corresponds to AdWords API Ad.id.
    /// </summary>
    public class AdWordsCreativeID : Dimension<string>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="AdWordsCreativeID" />.
        /// </summary>
        public AdWordsCreativeID()
            : base("AdWords Creative ID", "A string. Corresponds to AdWords API Ad.id.", false, "ga:adwordsCreativeID")
        {
        }
    }
}