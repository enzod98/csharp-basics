using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseDeDatos
{
    public abstract class DB
    {
        private string _connectionString;
        protected SqlConnection _connection;

        public DB(string serverName, string dbName, string user, string password)
        {
            _connectionString = //$@"Server=localhost\SQLEXPRESS01;Database=master;Trusted_Connection=True;";
            _connectionString = $"Server={ serverName }; Database={ dbName };" +
                $"Trusted_Connection=True;Encrypt=False";
        }

        public void Connect()
        {
            _connection = new SqlConnection(_connectionString);
            _connection.Open();
        }

        public void Close()
        {
            if(_connection != null && _connection.State == System.Data.ConnectionState.Open)
            _connection.Close();
        }

    }
}
