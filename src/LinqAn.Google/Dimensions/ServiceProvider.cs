namespace LinqAn.Google.Dimensions
{
    /// <summary>
    ///     The name of service providers used to reach your property. For example, if most users to your website come via the
    ///     major service providers for cable internet, you will see the names of those cable service providers in this
    ///     element.
    /// </summary>
    public class ServiceProvider : Dimension<string>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="ServiceProvider" />.
        /// </summary>
        public ServiceProvider()
            : base(
                "Service Provider",
                "The name of service providers used to reach your property. For example, if most users to your website come via the major service providers for cable internet, you will see the names of those cable service providers in this element.",
                true, "ga:networkLocation")
        {
        }
    }
}