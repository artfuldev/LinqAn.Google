namespace DotNetAnalytics.Google.Dimensions
{
    /// <summary>
    ///     The region of users, derived from IP addresses or Geographical IDs. In the U.S., a region is a state, such as New
    ///     York.
    /// </summary>
    public class RegionDimension : Dimension<string>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="RegionDimension" />.
        /// </summary>
        public RegionDimension()
            : base(
                "Region",
                "The region of users, derived from IP addresses or Geographical IDs. In the U.S., a region is a state, such as New York.",
                true, "ga:region")
        {
        }
    }
}