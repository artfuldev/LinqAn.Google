namespace LinqAn.Google.Core
{
    /// <summary>
    ///     Reprsents an entity that can be described. Usually contains a name and a description.
    /// </summary>
    public interface IDescribable
    {
        /// <summary>
        ///     The name of the <seealso cref="IDescribable" /> entity.
        /// </summary>
        string Name { get; }

        /// <summary>
        ///     The detailed description of the <seealso cref="IDescribable" /> entity.
        /// </summary>
        string Description { get; }
    }
}