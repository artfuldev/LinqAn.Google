namespace LinqAn.Google.Dimensions
{
    /// <summary>
    ///     Age bracket of user.
    /// </summary>
    public class Age : Dimension<string>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="Age" />.
        /// </summary>
        public Age() : base("Age", "Age bracket of user.", false, "ga:userAgeBracket")
        {
        }
    }
}