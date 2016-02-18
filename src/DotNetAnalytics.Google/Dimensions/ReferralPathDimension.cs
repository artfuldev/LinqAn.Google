namespace DotNetAnalytics.Google.Dimensions
{
    /// <summary>
    ///     The path of the referring URL (e.g. document.referrer). If someone places a link to your property on their website,
    ///     this element contains the path of the page that contains the referring link.
    /// </summary>
    public class ReferralPathDimension : Dimension<string>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="ReferralPathDimension" />.
        /// </summary>
        public ReferralPathDimension()
            : base(
                "Referral Path",
                "The path of the referring URL (e.g. document.referrer). If someone places a link to your property on their website, this element contains the path of the page that contains the referring link.",
                true, "ga:referralPath")
        {
        }
    }
}