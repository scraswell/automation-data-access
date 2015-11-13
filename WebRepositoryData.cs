using System.Collections.Generic;

namespace Craswell.Automation.DataAccess
{
    /// <summary>
    /// The web repository data model.
    /// </summary>
    public class WebRepositoryData : IWebRepository
    {
        /// <summary>
        /// Gets or sets the repository configuration identifier.
        /// </summary>
        /// <value>The identifier.</value>
        public virtual int Id { get; set; }

        /// <summary>
        /// Gets or sets the repository configuration name.
        /// </summary>
        /// <value>The name.</value>
        public virtual string Name { get; set; }

        /// <summary>
        /// Gets or sets the type of Web Repository.
        /// </summary>
        /// <value>The type of web repository.</value>
        public virtual WebRepositoryType Type { get; set; }

        /// <summary>
        /// Gets or sets the repository configuration.
        /// </summary>
        /// <value>The repository configuration.</value>
        public virtual WebRepositoryConfigurationData Configuration { get; set; }
    }
}

