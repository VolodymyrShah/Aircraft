using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aircraft
{
    internal class DB
    {
        NpgsqlConnection connection = new NpgsqlConnection(" Host = 127.0.0.1;  Port = 5432 ;Username = postgres; Password = 1111; Database = arline;");

        public void openConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
                connection.Open();
        }
        public void closeConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
                connection.Close();
        }

        public NpgsqlConnection getConnection()
        {
            return connection;
        }

        internal void AddData(string name, int numberOfSeats)
        {
            throw new NotImplementedException();
        }
     
    }
}
