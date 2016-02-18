namespace DotNetAnalytics.Google.Dimensions
{
    /// <summary>
    ///     The domain name of the ISPs used by users. This is derived from the domain name registered to the IP address.
    /// </summary>
    public class NetworkDomainDimension : Dimension<string>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="NetworkDomainDimension" />.
        /// </summary>
        public NetworkDomainDimension()
            : base(
                "Network Domain",
                "The domain name of the ISPs used by users. This is derived from the domain name registered to the IP address.",
                true, "ga:networkDomain")
        {
        }
    }
}