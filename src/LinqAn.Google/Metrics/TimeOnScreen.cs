using System;

namespace LinqAn.Google.Metrics
{
    /// <summary>
    ///     The time spent viewing the current screen.
    /// </summary>
    public class TimeOnScreen : Metric<TimeSpan>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="TimeOnScreen" />.
        /// </summary>
        public TimeOnScreen()
            : base("Time on Screen", "The time spent viewing the current screen.", true, "ga:timeOnScreen")
        {
        }
    }
}