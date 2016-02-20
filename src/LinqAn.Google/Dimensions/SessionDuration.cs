namespace LinqAn.Google.Dimensions
{
    /// <summary>
    ///     The length of a session measured in seconds and reported in second increments. The value returned is a string.
    /// </summary>
    public class SessionDuration : Dimension<string>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="SessionDuration" />.
        /// </summary>
        public SessionDuration()
            : base(
                "Session Duration",
                "The length of a session measured in seconds and reported in second increments. The value returned is a string.",
                true, "ga:sessionDurationBucket")
        {
        }
    }
}