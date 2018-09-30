using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace EdifyMe.Core.Data.context
{
    public class MSSqlContext : SqlContextHandler
    {
        public override IDbConnection CreateDbConnection()
        {
            return new SqlConnection(ConnectionString);
        }
    }
}
