using System.Linq;
using LinqAn.Google.Records;

namespace LinqAn.Google
{
    /// <summary>
    ///     The context within which an Analytics Reporting Session takes place. The context sets the context for the queries being made over the records. This includes access rights, credentials, authorization, etc.
    /// </summary>
    public interface IAnalyticsContext
    {
        /// <summary>
        ///     The records contained in this context. These records can be queried over within this context. Dimensions and metrics can be included, and filters and sort may be applied using normal Queryable method calls.
        /// </summary>
        IOrderedQueryable<IRecord> Records { get; }
    }
}