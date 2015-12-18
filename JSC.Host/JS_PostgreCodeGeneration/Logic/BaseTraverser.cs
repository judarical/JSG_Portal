/*
* Created by: Yevgeniy A. Matveichev
* Created: 18/12/2015
* Copyright © JSC Portal 2015
*/

namespace JS_PostgreCodeGeneration.Logic
{
    using System;
    using System.Data.SqlClient;

    public abstract class BaseTraverser : IDisposable
    {
        #region private fields and Properties
        
        private readonly SqlConnection connection;

        #endregion
        
        #region constructors
        
        protected BaseTraverser(string connectionString) : this(new SqlConnection(connectionString))
        {
        }

        /// <summary>
        /// Constructor for existing connection.
        /// </summary>
        /// <param name="connection">SqlConnection for traverser.</param>
        protected BaseTraverser(SqlConnection connection)
        {
            this.connection = connection;
            this.connection.Open();
            this.Options = TraverserOptionsBuilder.DefaultOptions;
        }

        public void Dispose()
        {
            connection.Close();
            connection.Dispose();
        }

        #endregion

        #region

        public TraverserOptions Options { get; set; }

        #endregion

        /// <summary>
        /// Template method for traversing the current level of abstraction.
        /// </summary>
        public void Traverse()
        {
            try
            {
                var command = new SqlCommand(this.Query, this.connection);
                this.PrepareCommand(command);
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    this.ProcessReader(reader);
                }

                reader.Close();
            }
            catch (SqlException exception)
            {
                // todo: log error here
                throw;
            }
        }

        #region abstract and virtual properties and methods

        protected abstract string Query { get; }

        /// <summary>
        /// The method prepares command for traversing (sets properties and parameters).
        /// </summary>
        /// <param name="command"></param>
        protected virtual void PrepareCommand(SqlCommand command)
        {
        }

        /// <summary>
        /// The method will read reader row and execute necessary action.
        /// </summary>
        /// <param name="reader"></param>
        protected abstract void ProcessReader(SqlDataReader reader);

        #endregion
    }
}
