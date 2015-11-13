using System;
using System.Collections.Generic;

namespace Craswell.Automation.DataAccess
{
    /// <summary>
    /// The web repository configuration data model.
    /// </summary>
    public class WebRepositoryConfigurationData : IWebRepositoryConfiguration
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        public virtual int Id { get; set; }

        /// <summary>
        /// Gets the address.
        /// </summary>
        /// <value>The address.</value>
        public virtual Uri Address { get; set; }

        /// <summary>
        /// Gets the username.
        /// </summary>
        /// <value>The username.</value>
        public virtual string Username { get; set; }

        /// <summary>
        /// Gets the password.
        /// </summary>
        /// <value>The password.</value>
        public virtual string Password { get; set; }

        /// <summary>
        /// Gets the security questions.
        /// </summary>
        /// <value>The security questions.</value>
        public virtual IDictionary<string, string> SecurityQuestions { get; set; }
    }
}

