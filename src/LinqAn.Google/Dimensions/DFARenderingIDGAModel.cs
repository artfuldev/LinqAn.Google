namespace LinqAn.Google.Dimensions
{
    /// <summary>
    ///     DCM rendering ID of the DCM click matching the Google Analytics session (premium only).
    /// </summary>
    public class DFARenderingIDGAModel : Dimension<string>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="DFARenderingIDGAModel" />.
        /// </summary>
        public DFARenderingIDGAModel()
            : base(
                "DFA Rendering ID (GA Model)",
                "DCM rendering ID of the DCM click matching the Google Analytics session (premium only).", false,
                "ga:dcmClickRenderingId")
        {
        }
    }
}