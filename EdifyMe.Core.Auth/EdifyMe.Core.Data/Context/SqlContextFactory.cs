using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace EdifyMe.Core.Data.context
{
    public class SqlContextFactory
    {
        public SqlContextFactory()
        {

        }

        public static SqlContextProvider GetSqlContext()
        {
            return new PGSqlContext();
        }
    }
}
