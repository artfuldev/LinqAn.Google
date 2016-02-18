namespace DotNetAnalytics.Google.Dimensions
{
    /// <summary>
    ///     DCM ad name of the last DCM event (impression or click within the DCM lookback window) associated with the Google
    ///     Analytics session (premium only).
    /// </summary>
    public class DFAAdDimension : Dimension<string>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="DFAAdDimension" />.
        /// </summary>
        public DFAAdDimension()
            : base(
                "DFA Ad",
                "DCM ad name of the last DCM event (impression or click within the DCM lookback window) associated with the Google Analytics session (premium only).",
                false, "ga:dcmLastEventAd")
        {
        }
    }
}