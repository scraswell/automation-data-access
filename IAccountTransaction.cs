using System;

namespace Craswell.Automation.DataAccess
{
    public interface IAccountTransaction
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        int Id { get; }

        /// <summary>
        /// Gets the transaction type.
        /// </summary>
        /// <value>The type.</value>
        TransactionType Type { get; }

        /// <summary>
        /// Gets or sets the timestamp.
        /// </summary>
        /// <value>The timestamp.</value>
        DateTime Timestamp { get; }

        /// <summary>
        /// Gets or sets the subject.
        /// </summary>
        /// <value>The subject.</value>
        string Subject { get; }

        /// <summary>
        /// Gets or sets the amount.
        /// </summary>
        /// <value>The amount.</value>
        double Amount { get; }
    }
}

