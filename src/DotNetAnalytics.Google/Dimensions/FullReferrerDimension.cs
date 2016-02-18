namespace DotNetAnalytics.Google.Dimensions
{
    /// <summary>
    ///     The full referring URL including the hostname and path.
    /// </summary>
    public class FullReferrerDimension : Dimension<string>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="FullReferrerDimension" />.
        /// </summary>
        public FullReferrerDimension()
            : base("Full Referrer", "The full referring URL including the hostname and path.", false, "ga:fullReferrer")
        {
        }
    }
}