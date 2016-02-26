namespace LinqAn.Google.Core
{
    /// <summary>
    ///     Represents an entity that supports indexing against Google Analytics.
    /// </summary>
    internal interface IIndexable
    {
        /// <summary>
        ///     The indexer of this <seealso cref="IIndexable" /> when passed to a Google Analytics API query.
        /// </summary>
        string Id { get; }
    }
}