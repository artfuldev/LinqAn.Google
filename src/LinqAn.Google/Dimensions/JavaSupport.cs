namespace LinqAn.Google.Dimensions
{
    /// <summary>
    ///     Indicates Java support for users' browsers. The possible values are Yes or No where the first letter must be
    ///     capitalized.
    /// </summary>
    public class JavaSupport : Dimension<string>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="JavaSupport" />.
        /// </summary>
        public JavaSupport()
            : base(
                "Java Support",
                "Indicates Java support for users' browsers. The possible values are Yes or No where the first letter must be capitalized.",
                true, "ga:javaEnabled")
        {
        }
    }
}