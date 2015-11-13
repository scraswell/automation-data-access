using System;

namespace Craswell.Automation.DataAccess
{
    /// <summary>
    /// The transaction data model.
    /// </summary>
    public class AccountTransactionData : IAccountTransaction
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        public virtual int Id { get; set; }

        /// <summary>
        /// Gets or sets the transaction type.
        /// </summary>
        /// <value>The transaction type.</value>
        public virtual TransactionType Type { get; set; }

        /// <summary>
        /// Gets or sets the timestamp.
        /// </summary>
        /// <value>The timestamp.</value>
        public virtual DateTime Timestamp { get; set; }

        /// <summary>
        /// Gets or sets the subject.
        /// </summary>
        /// <value>The subject.</value>
        public virtual string Subject { get; set; }

        /// <summary>
        /// Gets or sets the amount.
        /// </summary>
        /// <value>The amount.</value>
        public virtual double Amount { get; set; }
    }
}

