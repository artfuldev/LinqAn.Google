namespace LinqAn.Google.Dimensions
{
    /// <summary>
    ///     The user-scoped id of the particular variation that the user was exposed to during a content experiment.
    /// </summary>
    public class Variation : Dimension<string>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="Variation" />.
        /// </summary>
        public Variation()
            : base(
                "Variation",
                "The user-scoped id of the particular variation that the user was exposed to during a content experiment.",
                true, "ga:experimentVariant")
        {
        }
    }
}