namespace LinqAn.Google.Dimensions
{
    /// <summary>
    ///     The URLs your AdWords ads displayed.
    /// </summary>
    public class DisplayURL : Dimension<string>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="DisplayURL" />.
        /// </summary>
        public DisplayURL() : base("Display URL", "The URLs your AdWords ads displayed.", false, "ga:adDisplayUrl")
        {
        }
    }
}