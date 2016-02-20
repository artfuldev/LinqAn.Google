namespace LinqAn.Google.Dimensions
{
    /// <summary>
    ///     A string. Corresponds to AdWords API AccountInfo.customerId.
    /// </summary>
    public class AdWordsCustomerID : Dimension<string>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="AdWordsCustomerID" />.
        /// </summary>
        public AdWordsCustomerID()
            : base(
                "AdWords Customer ID", "A string. Corresponds to AdWords API AccountInfo.customerId.", false,
                "ga:adwordsCustomerID")
        {
        }
    }
}