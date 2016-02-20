namespace LinqAn.Google.Dimensions
{
    /// <summary>
    ///     DCM Floodlight advertiser ID associated with the floodlight conversion (premium only).
    /// </summary>
    public class DFAAdvertiserID : Dimension<string>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="DFAAdvertiserID" />.
        /// </summary>
        public DFAAdvertiserID()
            : base(
                "DFA Advertiser ID",
                "DCM Floodlight advertiser ID associated with the floodlight conversion (premium only).", false,
                "ga:dcmFloodlightAdvertiserId")
        {
        }
    }
}