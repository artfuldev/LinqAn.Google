namespace LinqAn.Google.Dimensions
{
    /// <summary>
    ///     The domains where your ads on the content network were placed.
    /// </summary>
    public class PlacementDomain : Dimension<string>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="PlacementDomain" />.
        /// </summary>
        public PlacementDomain()
            : base(
                "Placement Domain", "The domains where your ads on the content network were placed.", false,
                "ga:adPlacementDomain")
        {
        }
    }
}