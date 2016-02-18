namespace DotNetAnalytics.Google.Dimensions
{
    /// <summary>
    ///     The URLs where your ads on the content network were placed.
    /// </summary>
    public class PlacementURLDimension : Dimension<string>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="PlacementURLDimension" />.
        /// </summary>
        public PlacementURLDimension()
            : base(
                "Placement URL", "The URLs where your ads on the content network were placed.", false,
                "ga:adPlacementUrl")
        {
        }
    }
}