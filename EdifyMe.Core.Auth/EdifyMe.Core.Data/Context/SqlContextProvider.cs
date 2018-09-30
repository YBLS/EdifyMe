using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace EdifyMe.Core.Data.context
{
    public interface SqlContextProvider
    {
        string ConnectionString { get; set; }

        IDbConnection CreateDbConnection();
    }
}
