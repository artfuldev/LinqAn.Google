using System;

namespace DotNetAnalytics.Google.Metrics
{
    /// <summary>
    ///     The time spent viewing the current screen.
    /// </summary>
    public class TimeOnScreenMetric : Metric<TimeSpan>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="TimeOnScreenMetric" />.
        /// </summary>
        public TimeOnScreenMetric()
            : base("Time on Screen", "The time spent viewing the current screen.", true, "ga:timeOnScreen")
        {
        }
    }
}