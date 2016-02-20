namespace LinqAn.Google.Dimensions
{
    /// <summary>
    ///     The name of the resource's action being tracked.
    /// </summary>
    public class TimingLabel : Dimension<string>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="TimingLabel" />.
        /// </summary>
        public TimingLabel()
            : base("Timing Label", "The name of the resource's action being tracked.", true, "ga:userTimingLabel")
        {
        }
    }
}