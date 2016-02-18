namespace DotNetAnalytics.Google.Dimensions
{
    /// <summary>
    ///     The value provided when you define custom user segments for your property.
    /// </summary>
    public class UserDefinedValueDimension : Dimension<string>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="UserDefinedValueDimension" />.
        /// </summary>
        public UserDefinedValueDimension()
            : base(
                "User Defined Value", "The value provided when you define custom user segments for your property.", true,
                "ga:userDefinedValue")
        {
        }
    }
}