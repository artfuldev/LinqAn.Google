namespace DotNetAnalytics.Google.Dimensions
{
    /// <summary>
    ///     A string. Corresponds to AdWords API AdGroup.id.
    /// </summary>
    public class AdWordsAdGroupIDDimension : Dimension<string>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="AdWordsAdGroupIDDimension" />.
        /// </summary>
        public AdWordsAdGroupIDDimension()
            : base(
                "AdWords Ad Group ID", "A string. Corresponds to AdWords API AdGroup.id.", false, "ga:adwordsAdGroupID")
        {
        }
    }
}