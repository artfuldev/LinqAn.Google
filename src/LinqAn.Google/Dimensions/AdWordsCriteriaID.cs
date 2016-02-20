namespace LinqAn.Google.Dimensions
{
    /// <summary>
    ///     A string corresponding to the AdWords API Criterion.id. The geographical targeting Criteria IDs can be found at:
    ///     https://developers.google.com/analytics/devguides/collection/protocol/v1/geoid
    /// </summary>
    public class AdWordsCriteriaID : Dimension<string>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="AdWordsCriteriaID" />.
        /// </summary>
        public AdWordsCriteriaID()
            : base(
                "AdWords Criteria ID",
                "A string corresponding to the AdWords API Criterion.id. The geographical targeting Criteria IDs can be found at: https://developers.google.com/analytics/devguides/collection/protocol/v1/geoid",
                false, "ga:adwordsCriteriaID")
        {
        }
    }
}