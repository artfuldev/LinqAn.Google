namespace DotNetAnalytics.Google.Dimensions
{
    /// <summary>
    ///     The name of the day of the week (in English).
    /// </summary>
    public class DayOfWeekNameDimension : Dimension<string>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="DayOfWeekNameDimension" />.
        /// </summary>
        public DayOfWeekNameDimension()
            : base("Day of Week Name", "The name of the day of the week (in English).", false, "ga:dayOfWeekName")
        {
        }
    }
}