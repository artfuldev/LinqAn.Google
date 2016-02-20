namespace LinqAn.Google.Dimensions
{
    /// <summary>
    ///     Typically used to designate a supplying company or brick and mortar location; product affiliation.
    /// </summary>
    public class Affiliation : Dimension<string>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="Affiliation" />.
        /// </summary>
        public Affiliation()
            : base(
                "Affiliation",
                "Typically used to designate a supplying company or brick and mortar location; product affiliation.",
                true, "ga:affiliation")
        {
        }
    }
}