using System;
using System.Collections.Generic;

namespace Craswell.Automation.DataAccess
{
    /// <summary>
    /// The web repository configuration interface definition.
    /// </summary>
    public interface IWebRepositoryConfiguration
    {
        /// <summary>
        /// Gets the address.
        /// </summary>
        /// <value>The address.</value>
        Uri Address { get; }

        /// <summary>
        /// Gets the username.
        /// </summary>
        /// <value>The username.</value>
        string Username { get; }

        /// <summary>
        /// Gets the password.
        /// </summary>
        /// <value>The password.</value>
        string Password { get; }

        /// <summary>
        /// Gets the security questions.
        /// </summary>
        /// <value>The security questions.</value>
        IDictionary<string, string> SecurityQuestions { get; }
    }
}

