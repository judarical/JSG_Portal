/*
* Created by: Yevgeniy A. Matveichev
* Created: 18/12/2015
* Copyright © JSC Portal 2015
*/

namespace JS_PostgreCodeGeneration
{
    using System.Data.SqlClient;

    using JS_PostgreCodeGeneration.Logic;

    public class PostgreDatabaseTraverser : BaseTraverser
    {
        #region constructors
        public PostgreDatabaseTraverser(string connectionString)
            : base(connectionString)
        {
        }

        public PostgreDatabaseTraverser(SqlConnection connection)
            : base(connection)
        {
        }
        #endregion

        protected override string Query
        {
            get
            {
                return
                    string.Format(
                        "SELECT table_schema,table_name FROM information_schema.tables "
                        + "WHERE table_schema = '{0}' ORDER BY table_schema,table_name;",
                        this.Options.DatabaseSchema);
            }
        }

        protected override void ProcessReader(SqlDataReader reader)
        {
            
        }
    }
}
