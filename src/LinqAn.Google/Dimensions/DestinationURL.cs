namespace LinqAn.Google.Dimensions
{
    /// <summary>
    ///     The URLs to which your AdWords ads referred traffic.
    /// </summary>
    public class DestinationURL : Dimension<string>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="DestinationURL" />.
        /// </summary>
        public DestinationURL()
            : base(
                "Destination URL", "The URLs to which your AdWords ads referred traffic.", false, "ga:adDestinationUrl")
        {
        }
    }
}