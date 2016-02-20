namespace LinqAn.Google.Dimensions
{
    /// <summary>
    ///     Gender of user.
    /// </summary>
    public class Gender : Dimension<string>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="Gender" />.
        /// </summary>
        public Gender() : base("Gender", "Gender of user.", false, "ga:userGender")
        {
        }
    }
}