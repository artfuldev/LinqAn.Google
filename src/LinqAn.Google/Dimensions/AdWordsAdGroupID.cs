namespace LinqAn.Google.Dimensions
{
    /// <summary>
    ///     A string. Corresponds to AdWords API AdGroup.id.
    /// </summary>
    public class AdWordsAdGroupID : Dimension<string>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="AdWordsAdGroupID" />.
        /// </summary>
        public AdWordsAdGroupID()
            : base(
                "AdWords Ad Group ID", "A string. Corresponds to AdWords API AdGroup.id.", false, "ga:adwordsAdGroupID")
        {
        }
    }
}