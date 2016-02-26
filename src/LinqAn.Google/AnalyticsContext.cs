using System.Linq;
using Google.Apis.Services;
using LinqAn.Google.Linq.Queryables;
using LinqAn.Google.Profiles;
using LinqAn.Google.Records;

namespace LinqAn.Google
{
    /// <summary>
    ///     The context within which an Analytics Reporting Session takes place. The context sets the context for the queries
    ///     being made over the records. This includes access rights, credentials, authorization, etc.
    /// </summary>
    public sealed class AnalyticsContext : IAnalyticsContext
    {
        private readonly BaseClientService.Initializer _initializer;

        /// <summary>
        ///     Instantiates an <seealso cref="AnalyticsContext" /> with the given <seealso cref="BaseClientService.Initializer" />.
        /// </summary>
        /// <param name="initializer">
        ///     The <seealso cref="BaseClientService.Initializer" /> with which to construct an <seealso cref="AnalyticsContext" />.
        /// </param>
        public AnalyticsContext(BaseClientService.Initializer initializer)
        {
            _initializer = initializer;
        }

        /// <summary>
        ///     Instantiates an <seealso cref="AnalyticsContext" /> with the given <seealso cref="IAnalyticsProfile" />.
        /// </summary>
        /// <param name="profile">
        ///     The <seealso cref="IAnalyticsProfile" /> with which to construct an <seealso cref="AnalyticsContext" />.
        /// </param>
        public AnalyticsContext(IAnalyticsProfile profile) : this(profile.ToBaseClientServiceInitializer())
        {
        }

        /// <summary>
        ///     The records contained in this context. These records can be queried over within this context. Dimensions and
        ///     metrics can be included, and filters and sort may be applied using normal Queryable method calls.
        /// </summary>
        public IOrderedQueryable<IRecord> Records => new RecordsDataSet(_initializer);
    }
}