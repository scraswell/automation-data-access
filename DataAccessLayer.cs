using System;

using NHibernate;
using NHibernate.Cfg;

namespace Craswell.Automation.DataAccess
{
    /// <summary>
    /// Models the data access layer.
    /// </summary>
    public class DataAccessLayer : IDisposable
    {
        /// <summary>
        /// The session factory.
        /// </summary>
        private ISessionFactory sessionFactory;

        /// <summary>
        /// Releases unmanaged resources and performs other cleanup operations before the
        /// <see cref="Craswell.Automation.DataAccess.DataAccessLayer"/> is reclaimed by garbage collection.
        /// </summary>
        ~DataAccessLayer()
        {
            this.Dispose(false);
        }


        /// <summary>
        /// Opens the session with the data access layer.
        /// </summary>
        /// <returns>The session.</returns>
        public ISession OpenSession()
        {
            if (this.sessionFactory == null)
            {
                this.sessionFactory = new Configuration()
                    .Configure()
                    .AddAssembly(typeof(DataAccessLayer).Assembly)
                    .BuildSessionFactory();
            }

            return this.sessionFactory.OpenSession();
        }

        /// <summary>
        /// Releases all resource used by the <see cref="Craswell.Automation.DataAccess.DataAccessLayer"/> object.
        /// </summary>
        /// <remarks>Call <see cref="Dispose"/> when you are finished using the
        /// <see cref="Craswell.Automation.DataAccess.DataAccessLayer"/>. The <see cref="Dispose"/> method leaves the
        /// <see cref="Craswell.Automation.DataAccess.DataAccessLayer"/> in an unusable state. After calling
        /// <see cref="Dispose"/>, you must release all references to the
        /// <see cref="Craswell.Automation.DataAccess.DataAccessLayer"/> so the garbage collector can reclaim the memory
        /// that the <see cref="Craswell.Automation.DataAccess.DataAccessLayer"/> was occupying.</remarks>
        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }

        /// <summary>
        /// Dispose of this instance.
        /// </summary>
        /// <param name="disposing">If set to <c>true</c> disposing.</param>
        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (this.sessionFactory != null)
                {
                    this.sessionFactory.Dispose();
                    this.sessionFactory = null;
                }
            }
        }
    }
}

