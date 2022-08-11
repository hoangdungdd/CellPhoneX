using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CellPhoneX.Model;
using MySql.Data.MySqlClient;

namespace CellPhoneX.DAL
{
    public class UserDAL
    {
        private readonly MySqlConnection connection;
        public UserDAL()
        {
            this.connection = DBHelper.GetConnection();
        }

        public bool InsertUser(User user)
        {
            bool result = true;
            connection.Open();
            MySqlCommand cmd = new MySqlCommand($"insert into user({nameof(User.username)}, {nameof(User.password)}) values('{user.username}', '{user.password}')", connection);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch(Exception)
            {
                result = false;
            }
            finally
            {
                connection.Close();
            }
            
            return result;
        }
        public bool Login(User user)
        {
            bool result = false;
            connection.Open();
            MySqlCommand cmd = new MySqlCommand($"select * from user where {nameof(User.username)} = '{user.username}' and  {nameof(User.password)} = '{user.password}'", connection);
            try
            {
                var userInDB = new User();
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    user.user_id = reader.GetInt32(nameof(User.user_id));
                    user.name = reader[nameof(User.name)].ToString();
                    user.phone = reader[nameof(User.phone)].ToString();
                    user.balance = reader.GetInt32(nameof(User.balance));
                    Authenication.user = user;
                    Authenication.isAuthenication = true;
                    user.is_admin = reader.GetBoolean(nameof(User.is_admin));
                    result = true;
                    break;
                    
                }
            }
            catch(Exception)
            {
                Authenication.isAuthenication = false;
                return false;
                
            }
            finally
            {
                connection.Close();
            }
            return result;
        }


    }
}
