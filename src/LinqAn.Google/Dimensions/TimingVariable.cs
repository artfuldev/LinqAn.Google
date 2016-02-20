namespace LinqAn.Google.Dimensions
{
    /// <summary>
    ///     A value that can be used to add flexibility in visualizing user timings in the reports.
    /// </summary>
    public class TimingVariable : Dimension<string>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="TimingVariable" />.
        /// </summary>
        public TimingVariable()
            : base(
                "Timing Variable",
                "A value that can be used to add flexibility in visualizing user timings in the reports.", true,
                "ga:userTimingVariable")
        {
        }
    }
}