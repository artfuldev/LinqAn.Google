namespace DotNetAnalytics.Google.Dimensions
{
    /// <summary>
    ///     The number of days between users' purchases and the related campaigns that lead to the purchases.
    /// </summary>
    public class DaysToTransactionDimension : Dimension<string>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="DaysToTransactionDimension" />.
        /// </summary>
        public DaysToTransactionDimension()
            : base(
                "Days to Transaction",
                "The number of days between users' purchases and the related campaigns that lead to the purchases.",
                true, "ga:daysToTransaction")
        {
        }
    }
}