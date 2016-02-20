namespace LinqAn.Google.Dimensions
{
    /// <summary>
    ///     The approximate latitude of the user's city. Derived from IP addresses or Geographical IDs. Locations north of the
    ///     equator are represented by positive values and locations south of the equator by negative values.
    /// </summary>
    public class Latitude : Dimension<string>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="Latitude" />.
        /// </summary>
        public Latitude()
            : base(
                "Latitude",
                "The approximate latitude of the user's city. Derived from IP addresses or Geographical IDs. Locations north of the equator are represented by positive values and locations south of the equator by negative values.",
                false, "ga:latitude")
        {
        }
    }
}