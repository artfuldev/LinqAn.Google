namespace LinqAn.Google.Dimensions
{
    /// <summary>
    ///     DCM site placement name of the DCM click matching the Google Analytics session (premium only).
    /// </summary>
    public class DFAPlacementGAModel : Dimension<string>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="DFAPlacementGAModel" />.
        /// </summary>
        public DFAPlacementGAModel()
            : base(
                "DFA Placement (GA Model)",
                "DCM site placement name of the DCM click matching the Google Analytics session (premium only).", false,
                "ga:dcmClickSitePlacement")
        {
        }
    }
}