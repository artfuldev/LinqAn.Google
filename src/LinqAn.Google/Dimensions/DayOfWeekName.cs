namespace LinqAn.Google.Dimensions
{
    /// <summary>
    ///     The name of the day of the week (in English).
    /// </summary>
    public class DayOfWeekName : Dimension<string>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="DayOfWeekName" />.
        /// </summary>
        public DayOfWeekName()
            : base("Day of Week Name", "The name of the day of the week (in English).", false, "ga:dayOfWeekName")
        {
        }
    }
}