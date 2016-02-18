namespace DotNetAnalytics.Google.Dimensions
{
    /// <summary>
    ///     The data source of a hit. By default, hits sent from ga.js and analytics.js are reported as "web". Hits sent from
    ///     the mobile SDKs are reported as "app". These values can be overridden in the Measurement Protocol.
    /// </summary>
    public class DataSourceDimension : Dimension<string>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="DataSourceDimension" />.
        /// </summary>
        public DataSourceDimension()
            : base(
                "Data Source",
                "The data source of a hit. By default, hits sent from ga.js and analytics.js are reported as \"web\". Hits sent from the mobile SDKs are reported as \"app\". These values can be overridden in the Measurement Protocol.",
                true, "ga:dataSource")
        {
        }
    }
}