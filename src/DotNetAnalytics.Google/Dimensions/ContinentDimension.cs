namespace DotNetAnalytics.Google.Dimensions
{
    /// <summary>
    ///     The continents of users, derived from IP addresses or Geographical IDs.
    /// </summary>
    public class ContinentDimension : Dimension<string>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="ContinentDimension" />.
        /// </summary>
        public ContinentDimension()
            : base(
                "Continent", "The continents of users, derived from IP addresses or Geographical IDs.", true,
                "ga:continent")
        {
        }
    }
}