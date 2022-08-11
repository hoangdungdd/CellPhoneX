using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CellPhoneX.DAL
{
        public class DBHelper
        {
            private static MySqlConnection connection;
            DBHelper()
            {
                GetConnection();

            }
            public static MySqlConnection GetConnection()

            {
                if (connection == null)
                {
                    connection = new MySqlConnection
                    {
                        ConnectionString = $"server=localhost;user id = root; password = kiugaming123; port = 3306; database = cellphonex"
                    };
                }
                return connection;
            }
            public static MySqlDataReader ExecQuery(string query)
            {
                MySqlCommand command = new MySqlCommand(query, connection);
                return command.ExecuteReader();
            }
            public static MySqlConnection OpenConnection()
            {
                if (connection == null)
                {
                    GetConnection();
                }
                connection.Open();
                return connection;
            }
            public static void CloseConnection()
            {
                if (connection != null) connection.Close();
            }

        }
}
