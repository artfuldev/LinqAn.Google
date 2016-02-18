namespace DotNetAnalytics.Google.Dimensions
{
    /// <summary>
    ///     Site name where the DCM creative was shown and clicked on for the last DCM event (impression or click within the
    ///     DCM lookback window) associated with the Google Analytics session (premium only).
    /// </summary>
    public class DFASiteDFAModelDimension : Dimension<string>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="DFASiteDFAModelDimension" />.
        /// </summary>
        public DFASiteDFAModelDimension()
            : base(
                "DFA Site (DFA Model)",
                "Site name where the DCM creative was shown and clicked on for the last DCM event (impression or click within the DCM lookback window) associated with the Google Analytics session (premium only).",
                false, "ga:dcmLastEventSite")
        {
        }
    }
}