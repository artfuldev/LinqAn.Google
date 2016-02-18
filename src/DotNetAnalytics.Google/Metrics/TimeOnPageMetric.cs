using System;

namespace DotNetAnalytics.Google.Metrics
{
    /// <summary>
    ///     How long a user spent on a particular page in seconds. Calculated by subtracting the initial view time for a
    ///     particular page from the initial view time for a subsequent page. Thus, this metric does not apply to exit pages
    ///     for your property.
    /// </summary>
    public class TimeOnPageMetric : Metric<TimeSpan>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="TimeOnPageMetric" />.
        /// </summary>
        public TimeOnPageMetric()
            : base(
                "Time on Page",
                "How long a user spent on a particular page in seconds. Calculated by subtracting the initial view time for a particular page from the initial view time for a subsequent page. Thus, this metric does not apply to exit pages for your property.",
                true, "ga:timeOnPage")
        {
        }
    }
}