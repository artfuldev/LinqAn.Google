namespace LinqAn.Google.Metrics
{
    /// <summary>
    ///     DCM Total Clicks (premium only).
    /// </summary>
    public class DFAClicks : Metric<int>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="DFAClicks" />.
        /// </summary>
        public DFAClicks() : base("DFA Clicks", "DCM Total Clicks (premium only).", false, "ga:dcmClicks")
        {
        }
    }
}