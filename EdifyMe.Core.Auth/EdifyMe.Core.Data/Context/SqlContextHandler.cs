using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace EdifyMe.Core.Data.context
{
    public abstract class SqlContextHandler : SqlContextProvider
    {
        public string ConnectionString { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public abstract IDbConnection CreateDbConnection();
    }
}
