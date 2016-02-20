namespace LinqAn.Google.Dimensions
{
    /// <summary>
    ///     A string for categorizing all user timing variables into logical groups for easier reporting purposes.
    /// </summary>
    public class TimingCategory : Dimension<string>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="TimingCategory" />.
        /// </summary>
        public TimingCategory()
            : base(
                "Timing Category",
                "A string for categorizing all user timing variables into logical groups for easier reporting purposes.",
                true, "ga:userTimingCategory")
        {
        }
    }
}