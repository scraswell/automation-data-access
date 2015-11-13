namespace Craswell.Automation.DataAccess
{
    /// <summary>
    /// The web repository interface definition.
    /// </summary>
    public interface IWebRepository
    {
        /// <summary>
        /// Gets the repository identifier.
        /// </summary>
        /// <value>The identifier.</value>
        int Id { get; }

        /// <summary>
        /// Gets the name of the repository.
        /// </summary>
        /// <value>The name of the repository.</value>
        string Name { get; }

        /// <summary>
        /// Gets the repository type.
        /// </summary>
        /// <value>The repository type.</value>
        WebRepositoryType Type { get; }
    }
}

