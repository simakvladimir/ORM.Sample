using ORM.Sample.Core.Db;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ORM.Sample.MSSQL
{
    public class MssqlProvider : DbProvider
    {
        public override void Configure()
        {
            CreateDatabase();
        }

        private string GetConnectionDbName()
        {
            Match match = Regex.Match(Connection, @"initial catalog=(.*);", RegexOptions.IgnoreCase);
            if (match.Success)
            {
                return match.Groups[1].Value;
            }
            return string.Empty;
        }

        private string GetServer()
        {
            Match match = Regex.Match(Connection, @"Server=(.*?);", RegexOptions.IgnoreCase);
            if (match.Success)
            {
                return match.Groups[1].Value;
            }
            return string.Empty;
        }

        private void CreateDatabase()
        {
            var dbName = GetConnectionDbName();
            if (string.IsNullOrEmpty(dbName))
                return;

            try
            {
                using (var connection = new SqlConnection("Server=" + GetServer()))
                {
                    connection.Open();
                    var command = new SqlCommand(string.Format("IF NOT EXISTS(SELECT * FROM sys.databases WHERE name = '{0}') CREATE DATABASE {1}", dbName, dbName), connection);
                    command.ExecuteNonQuery();
                }
            }
            catch (SqlException e)
            {
            }
        }
    }
}
