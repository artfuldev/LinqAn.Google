namespace LinqAn.Google.Dimensions
{
    /// <summary>
    ///     The source of referrals. When using manual campaign tracking, the value of the utm_source campaign tracking
    ///     parameter. When using AdWords autotagging, the value is google. Otherwise the domain of the source referring the
    ///     user (e.g. document.referrer). The value may also contain a port address. If the user arrived without a referrer,
    ///     the value is (direct)
    /// </summary>
    public class Source : Dimension<string>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="Source" />.
        /// </summary>
        public Source()
            : base(
                "Source",
                "The source of referrals. When using manual campaign tracking, the value of the utm_source campaign tracking parameter. When using AdWords autotagging, the value is google. Otherwise the domain of the source referring the user (e.g. document.referrer). The value may also contain a port address. If the user arrived without a referrer, the value is (direct)",
                true, "ga:source")
        {
        }
    }
}