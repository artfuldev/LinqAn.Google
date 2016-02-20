namespace LinqAn.Google.Dimensions
{
    /// <summary>
    ///     The user-scoped id of the content experiment that the user was exposed to when the metrics were reported.
    /// </summary>
    public class ExperimentID : Dimension<string>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="ExperimentID" />.
        /// </summary>
        public ExperimentID()
            : base(
                "Experiment ID",
                "The user-scoped id of the content experiment that the user was exposed to when the metrics were reported.",
                true, "ga:experimentId")
        {
        }
    }
}