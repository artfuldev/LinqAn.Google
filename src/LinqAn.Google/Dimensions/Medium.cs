namespace LinqAn.Google.Dimensions
{
    /// <summary>
    ///     The type of referrals. When using manual campaign tracking, the value of the utm_medium campaign tracking
    ///     parameter. When using AdWords autotagging, the value is ppc. If the user comes from a search engine detected by
    ///     Google Analytics, the value is organic. If the referrer is not a search engine, the value is referral. If the users
    ///     came directly to the property, and document.referrer is empty, the value is (none).
    /// </summary>
    public class Medium : Dimension<string>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="Medium" />.
        /// </summary>
        public Medium()
            : base(
                "Medium",
                "The type of referrals. When using manual campaign tracking, the value of the utm_medium campaign tracking parameter. When using AdWords autotagging, the value is ppc. If the user comes from a search engine detected by Google Analytics, the value is organic. If the referrer is not a search engine, the value is referral. If the users came directly to the property, and document.referrer is empty, the value is (none).",
                true, "ga:medium")
        {
        }
    }
}