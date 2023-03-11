using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Framework.Persistance
{
    public class DbConnectionFactory : IConnectionFactory
    {
        private readonly string _connectionString;
        private readonly string _name;

        public DbConnectionFactory(string connectionName)
        {
            if (connectionName == null) throw new ArgumentNullException("connectionName");

            var conStr = ConfigurationManager.ConnectionStrings[connectionName];
            if (conStr == null)
                throw new ConfigurationErrorsException(string.Format("Failed to find connection string named '{0}' in app/web.config.", connectionName));

            _name = conStr.ProviderName;
            //  _provider = DbProviderFactories.GetFactory(conStr.ProviderName);
            _connectionString = conStr.ConnectionString;

        }

        public IDbConnection Create()
        {
            //  var connection = _provider.CreateConnection();
            var connection = new SqlConnection(_connectionString);
            if (connection == null)
                throw new ConfigurationErrorsException(string.Format("Failed to create a connection using the connection string named '{0}' in app/web.config.", _name));

            connection.ConnectionString = _connectionString;
            return connection;
        }
    }
}
