namespace LinqAn.Google.Dimensions
{
    /// <summary>
    ///     The city IDs of users, derived from IP addresses or Geographical IDs. The city IDs are the same as the Criteria IDs
    ///     found at: https://developers.google.com/analytics/devguides/collection/protocol/v1/geoid
    /// </summary>
    public class CityID : Dimension<string>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="CityID" />.
        /// </summary>
        public CityID()
            : base(
                "City ID",
                "The city IDs of users, derived from IP addresses or Geographical IDs. The city IDs are the same as the Criteria IDs found at: https://developers.google.com/analytics/devguides/collection/protocol/v1/geoid",
                false, "ga:cityId")
        {
        }
    }
}