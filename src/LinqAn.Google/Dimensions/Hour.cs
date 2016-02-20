namespace LinqAn.Google.Dimensions
{
    /// <summary>
    ///     A two-digit hour of the day ranging from 00-23 in the timezone configured for the account. This value is also
    ///     corrected for daylight savings time, adhering to all local rules for daylight savings time. If your timezone
    ///     follows daylight savings time, there will be an apparent bump in the number of sessions during the change-over hour
    ///     (e.g. between 1:00 and 2:00) for the day per year when that hour repeats. A corresponding hour with zero sessions
    ///     will occur at the opposite changeover. (Google Analytics does not track user time more precisely than hours.)
    /// </summary>
    public class Hour : Dimension<string>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="Hour" />.
        /// </summary>
        public Hour()
            : base(
                "Hour",
                "A two-digit hour of the day ranging from 00-23 in the timezone configured for the account. This value is also corrected for daylight savings time, adhering to all local rules for daylight savings time. If your timezone follows daylight savings time, there will be an apparent bump in the number of sessions during the change-over hour (e.g. between 1:00 and 2:00) for the day per year when that hour repeats. A corresponding hour with zero sessions will occur at the opposite changeover. (Google Analytics does not track user time more precisely than hours.)",
                true, "ga:hour")
        {
        }
    }
}