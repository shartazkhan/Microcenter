using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microcenter.Data_Access_Layer.Entities;

namespace Microcenter.Data_Access_Layer
{
    class UserDataAccess : DataAccess
    {
        public List<User> GetUsers()
        {
                string sql = "SELECT * FROM Users";
                SqlDataReader reader = this.GetData(sql);
                List<User> users = new List<User>();

                while (reader.Read())
                {
                    User user = new User();

                    user.EmployeeID = Convert.ToInt32(reader["EmployeeID"]);
                    user.Name = reader["Name"].ToString();
                    user.Password = reader["Password"].ToString();
                    user.Type = reader["Type"].ToString();
                    user.Position = reader["Position"].ToString();
                    users.Add(user);
                }
                return users;
        }
            public User GetUsers(string username)
            {
                string sql = "SELECT * FROM Users WHERE Username='" + username + "'";
                SqlDataReader reader = this.GetData(sql);
                if (reader.Read())
                {
                    User user = new User();
                    user.EmployeeID = Convert.ToInt32(reader["EmployeeID"]);
                    user.Name = reader["Name"].ToString();
                    user.Password = reader["Password"].ToString();
                    user.Type = reader["Type"].ToString();
                    user.Position = reader["Position"].ToString();
                    return user;
                }
                return null;
            }



            public int AddUser(User user)
            {
                string sql = "INSERT INTO Users(EmployeeID,Name,Password,Type,Position) VALUES(" + user.EmployeeID + ",'" + user.Name + "','" + user.Password + "', '" + user.Type + "', '" + user.Position + "')";
                return this.ExecuteQuery(sql);
            }

            public int UpdateUser(User user)
            {
                string sql = "UPDATE Users SET Name='" + user.Name + "',Password='" + user.Password + "',Type='" + user.Type + "',Position='" + user.Position + "' WHERE Username='" + user.Name + "'";
                return this.ExecuteQuery(sql);
            }
            public int DeleteUser(string employeeID)
            {
                string sql = "DELETE FROM Users WHERE EmployeeID='" + employeeID + "'";
                return this.ExecuteQuery(sql);
            }

            public string GetUsername(string employeeID)
            {
                string sql = "SELECT Name FROM Users WHERE EmployeeID='" + employeeID + "'";
                SqlDataReader reader = this.GetData(sql);
                if (reader.Read())
                {
                    return reader["Name"].ToString();
                }
                return null;
            }

    }
}
