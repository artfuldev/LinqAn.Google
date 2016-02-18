using System;

namespace DotNetAnalytics.Google.Metrics
{
    /// <summary>
    ///     The total duration of user sessions represented in total seconds.
    /// </summary>
    public class SessionDurationMetric : Metric<TimeSpan>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="SessionDurationMetric" />.
        /// </summary>
        public SessionDurationMetric()
            : base(
                "Session Duration", "The total duration of user sessions represented in total seconds.", true,
                "ga:sessionDuration")
        {
        }
    }
}