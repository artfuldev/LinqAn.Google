namespace LinqAn.Google.Dimensions
{
    /// <summary>
    ///     The country of users, derived from IP addresses or Geographical IDs.
    /// </summary>
    public class Country : Dimension<string>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="Country" />.
        /// </summary>
        public Country()
            : base("Country", "The country of users, derived from IP addresses or Geographical IDs.", true, "ga:country"
                )
        {
        }
    }
}