using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using Dapper;
using EdifyMe.Core.Data.context;

namespace EdifyMe.Core.Data
{
    public static class DbContext
    {
        private static IDbConnection _dbConnection;

        static DbContext()
        {
            _dbConnection = SqlContextFactory.GetSqlContext().CreateDbConnection();
        }

        public static IEnumerable<dynamic> Query(string sql, object param = null, IDbTransaction transaction = null)
        {
            return _dbConnection.Query(sql, param, transaction);
        }

        public static IEnumerable<T> Query<T>(string sql, object param = null, IDbTransaction transaction = null)
        {
            return _dbConnection.Query<T>(sql, param, transaction);
        }

        public static void Insert(string sql, object param = null, IDbTransaction transaction = null)
        {
            _dbConnection.Execute(sql, param, transaction);
        }

        public static int BatchInsert(string sql, object param = null, IDbTransaction transaction = null)
        {
            return _dbConnection.Execute(sql, param, transaction);
        }

        public static void Update(string sql, object param = null, IDbTransaction transaction = null)
        {
            _dbConnection.Execute(sql, param, transaction);
        }

        public static int BatchUpdate(string sql, object param = null, IDbTransaction transaction = null)
        {
            return _dbConnection.Execute(sql, param, transaction);
        }
    }
}
