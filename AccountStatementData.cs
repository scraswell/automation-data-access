using System;

namespace Craswell.Automation.DataAccess
{
    /// <summary>
    /// Statement data model.
    /// </summary>
    public class AccountStatementData : IAccountStatement
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        public virtual int Id { get; set; }

        /// <summary>
        /// Gets or sets the timestamp.
        /// </summary>
        /// <value>The timestamp.</value>
        public virtual DateTime Timestamp { get; set; }

        /// <summary>
        /// Gets or sets the account number.
        /// </summary>
        /// <value>The account number.</value>
        public virtual string AccountNumber { get; set; }

        /// <summary>
        /// Gets or sets the name of the file.
        /// </summary>
        /// <value>The name of the file.</value>
        public virtual string FileName { get; set; }
    }
}

