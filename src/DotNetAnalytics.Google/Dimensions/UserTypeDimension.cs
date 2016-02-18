namespace DotNetAnalytics.Google.Dimensions
{
    /// <summary>
    ///     A boolean indicating if a user is new or returning. Possible values: New Visitor, Returning Visitor.
    /// </summary>
    public class UserTypeDimension : Dimension<string>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="UserTypeDimension" />.
        /// </summary>
        public UserTypeDimension()
            : base(
                "User Type",
                "A boolean indicating if a user is new or returning. Possible values: New Visitor, Returning Visitor.",
                true, "ga:userType")
        {
        }
    }
}