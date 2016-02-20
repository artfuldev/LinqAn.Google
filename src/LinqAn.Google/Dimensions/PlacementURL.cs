namespace LinqAn.Google.Dimensions
{
    /// <summary>
    ///     The URLs where your ads on the content network were placed.
    /// </summary>
    public class PlacementURL : Dimension<string>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="PlacementURL" />.
        /// </summary>
        public PlacementURL()
            : base(
                "Placement URL", "The URLs where your ads on the content network were placed.", false,
                "ga:adPlacementUrl")
        {
        }
    }
}