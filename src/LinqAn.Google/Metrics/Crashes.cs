namespace LinqAn.Google.Metrics
{
    /// <summary>
    ///     The number of exceptions where isFatal is set to true.
    /// </summary>
    public class Crashes : Metric<int>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="Crashes" />.
        /// </summary>
        public Crashes()
            : base("Crashes", "The number of exceptions where isFatal is set to true.", true, "ga:fatalExceptions")
        {
        }
    }
}