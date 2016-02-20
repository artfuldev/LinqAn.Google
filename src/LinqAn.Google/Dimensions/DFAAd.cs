namespace LinqAn.Google.Dimensions
{
    /// <summary>
    ///     DCM ad name of the last DCM event (impression or click within the DCM lookback window) associated with the Google
    ///     Analytics session (premium only).
    /// </summary>
    public class DFAAd : Dimension<string>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="DFAAd" />.
        /// </summary>
        public DFAAd()
            : base(
                "DFA Ad",
                "DCM ad name of the last DCM event (impression or click within the DCM lookback window) associated with the Google Analytics session (premium only).",
                false, "ga:dcmLastEventAd")
        {
        }
    }
}