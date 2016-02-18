namespace DotNetAnalytics.Google.Dimensions
{
    /// <summary>
    ///     The hostname from which the tracking request was made.
    /// </summary>
    public class HostnameDimension : Dimension<string>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="HostnameDimension" />.
        /// </summary>
        public HostnameDimension()
            : base("Hostname", "The hostname from which the tracking request was made.", true, "ga:hostname")
        {
        }
    }
}