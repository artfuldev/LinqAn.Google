namespace LinqAn.Google.Dimensions
{
    /// <summary>
    ///     How you manage your ads on the content network. Values are Automatic placements or Managed placements.
    /// </summary>
    public class PlacementType : Dimension<string>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="PlacementType" />.
        /// </summary>
        public PlacementType()
            : base(
                "Placement Type",
                "How you manage your ads on the content network. Values are Automatic placements or Managed placements.",
                false, "ga:adTargetingOption")
        {
        }
    }
}