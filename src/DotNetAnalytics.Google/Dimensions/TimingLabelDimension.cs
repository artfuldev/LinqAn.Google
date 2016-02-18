namespace DotNetAnalytics.Google.Dimensions
{
    /// <summary>
    ///     The name of the resource's action being tracked.
    /// </summary>
    public class TimingLabelDimension : Dimension<string>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="TimingLabelDimension" />.
        /// </summary>
        public TimingLabelDimension()
            : base("Timing Label", "The name of the resource's action being tracked.", true, "ga:userTimingLabel")
        {
        }
    }
}