using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microcenter.Data_Access_Layer.Entities;

namespace Microcenter.Data_Access_Layer
{
    class EmployeeDataAccess : DataAccess
    {
        public List<Employee> GetEmployees()
        {
            string sql = "SELECT * FROM Employees";
            SqlDataReader reader = this.GetData(sql);
            List<Employee> employees = new List<Employee>();
            while (reader.Read())
            {
                Employee employee = new Employee();
                employee.EmployeeID = Convert.ToInt32(reader["EmployeeID"]);
                employee.Name = reader["Name"].ToString();
                employee.Contact = Convert.ToInt32(reader["Contact"]);
                employee.Gender = reader["Gender"].ToString();
                employee.DoB = reader["DoB"].ToString();
                employee.EmployeeType = Convert.ToInt32(reader["EmployeeType"]);
                employee.HireDate = reader["HireDate"].ToString();
                employee.Position = reader["Position"].ToString();
                employee.Picture = reader["Picture"].ToString();
                employees.Add(employee);
            }
            return employees;
        }
   
        public int AddEmployee(Employee employee)
        {
            string sql = "INSERT INTO Users(Name,Contact,Gender,DoB,EmployeeType,HireDate,Position,Picture) VALUES('" + employee.Name + "'," + employee.Contact + ",'" + employee.Gender + "','" + employee.DoB + "'," + employee.EmployeeType + ",'" + employee.HireDate + "','" + employee.Position + "', '" + employee.Picture + "',)";
            return this.ExecuteQuery(sql);
        }

        public int UpdateEmployee(Employee employee)
        {
            string sql = "UPDATE Employees SET Name='" + employee.Name + "',Contact=" + employee.Contact + ",Gender='" + employee.Gender + "',DoB='" + employee.DoB + "',EmployeeType=" + employee.EmployeeType + ",HireDate='" + employee.HireDate + "',Position='" + employee.Position + "',Picture='" + employee.Picture + "' WHERE EmployeeID=" + employee.EmployeeID;
            return this.ExecuteQuery(sql);
        }
        public int DeleteEmployee(int employeeId)
        {
            string sql = "DELETE FROM Employees WHERE EmployeeID='" + employeeId + "'";
            return this.ExecuteQuery(sql);
        }

        
    }
}
