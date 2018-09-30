using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Npgsql;

namespace EdifyMe.Core.Data.context
{
    public class PGSqlContext : SqlContextHandler
    {
        public override IDbConnection CreateDbConnection()
        {
            return new NpgsqlConnection(ConnectionString);
        }
    }
}
