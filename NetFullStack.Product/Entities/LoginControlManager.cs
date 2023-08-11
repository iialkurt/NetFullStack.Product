using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFullStack.Product.Entities
{
    public class LoginControlManager
    {
        public string LoginControl(string username, string password)
        {
            if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password))
            {
                ConnectionManager con = new ConnectionManager();
                con.con();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con.con();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select User,Password,UserFullName from AppUser where Username=@username and Password=@password";
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("Password", password);
                var dr = cmd.ExecuteReader();
                cmd.Parameters.Clear();
                string UserFullName = "";
                while (dr.Read())
                {
                    UserFullName = Convert.ToString(dr[2]);
                }
                con.con().Close();
                return UserFullName;


            }
            else
            {
                return "";   
            }
        }
    }

}