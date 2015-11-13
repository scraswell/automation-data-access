using System;

namespace Craswell.Automation.DataAccess
{
    public interface IAccountStatement
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        int Id { get; }

        /// <summary>
        /// Gets or sets the timestamp.
        /// </summary>
        /// <value>The timestamp.</value>
        DateTime Timestamp { get; }

        /// <summary>
        /// Gets or sets the account number.
        /// </summary>
        /// <value>The account number.</value>
        string AccountNumber { get; }

        /// <summary>
        /// Gets or sets the name of the file.
        /// </summary>
        /// <value>The name of the file.</value>
        string FileName { get; }
    }
}

