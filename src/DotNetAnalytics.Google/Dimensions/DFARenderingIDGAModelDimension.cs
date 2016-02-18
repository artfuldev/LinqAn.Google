namespace DotNetAnalytics.Google.Dimensions
{
    /// <summary>
    ///     DCM rendering ID of the DCM click matching the Google Analytics session (premium only).
    /// </summary>
    public class DFARenderingIDGAModelDimension : Dimension<string>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="DFARenderingIDGAModelDimension" />.
        /// </summary>
        public DFARenderingIDGAModelDimension()
            : base(
                "DFA Rendering ID (GA Model)",
                "DCM rendering ID of the DCM click matching the Google Analytics session (premium only).", false,
                "ga:dcmClickRenderingId")
        {
        }
    }
}