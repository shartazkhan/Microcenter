﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microcenter.Data_Access_Layer.Entities;

namespace Microcenter.Data_Access_Layer
{
    class LoginDataAccess : DataAccess
    {
        public string UserLoginValidation(User user)
        {
            string sql = "SELECT Position FROM Users WHERE EmployeeID='" + user.EmployeeID + "' AND Password='" + user.Password + "'";
            SqlDataReader reader = this.GetData(sql);
            if (reader.Read())
            {
                return user.Position = user.Position = reader["Position"].ToString();
            }
            return null;
        }
    }
}
