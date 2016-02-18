namespace DotNetAnalytics.Google.Dimensions
{
    /// <summary>
    ///     The user-scoped id of the content experiment that the user was exposed to when the metrics were reported.
    /// </summary>
    public class ExperimentIDDimension : Dimension<string>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="ExperimentIDDimension" />.
        /// </summary>
        public ExperimentIDDimension()
            : base(
                "Experiment ID",
                "The user-scoped id of the content experiment that the user was exposed to when the metrics were reported.",
                true, "ga:experimentId")
        {
        }
    }
}