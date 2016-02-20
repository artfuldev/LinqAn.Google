namespace LinqAn.Google.Dimensions
{
    /// <summary>
    ///     The value provided when you define custom user segments for your property.
    /// </summary>
    public class UserDefinedValue : Dimension<string>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="UserDefinedValue" />.
        /// </summary>
        public UserDefinedValue()
            : base(
                "User Defined Value", "The value provided when you define custom user segments for your property.", true,
                "ga:userDefinedValue")
        {
        }
    }
}