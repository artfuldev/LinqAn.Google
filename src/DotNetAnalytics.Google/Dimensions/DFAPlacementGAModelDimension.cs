namespace DotNetAnalytics.Google.Dimensions
{
    /// <summary>
    ///     DCM site placement name of the DCM click matching the Google Analytics session (premium only).
    /// </summary>
    public class DFAPlacementGAModelDimension : Dimension<string>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="DFAPlacementGAModelDimension" />.
        /// </summary>
        public DFAPlacementGAModelDimension()
            : base(
                "DFA Placement (GA Model)",
                "DCM site placement name of the DCM click matching the Google Analytics session (premium only).", false,
                "ga:dcmClickSitePlacement")
        {
        }
    }
}