namespace LinqAn.Google.Dimensions
{
    /// <summary>
    ///     For social interactions, a value representing the URL (or resource) which receives the social network action.
    /// </summary>
    public class SocialEntity : Dimension<string>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="SocialEntity" />.
        /// </summary>
        public SocialEntity()
            : base(
                "Social Entity",
                "For social interactions, a value representing the URL (or resource) which receives the social network action.",
                false, "ga:socialInteractionTarget")
        {
        }
    }
}