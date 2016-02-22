namespace LinqAn.Google.Core
{
    /// <summary>
    ///     Reprsents an entity that can be identified by a name. Usually contains a name.
    /// </summary>
    public interface IIdentifiable
    {
        /// <summary>
        ///     The name of the <seealso cref="IIdentifiable" /> entity.
        /// </summary>
        string Name { get; }
    }
}