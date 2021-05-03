using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microcenter.Data_Access_Layer;
using Microcenter.Data_Access_Layer.Entities;

namespace Microcenter.Business_Logic_Layer
{
    class EmployeeService
    {
        EmployeeDataAccess employeeDataAccess;

        public EmployeeService()
        {
            this.employeeDataAccess = new EmployeeDataAccess();
        }

        public List<Employee> GetAllEmployee()
        {
            return this.employeeDataAccess.GetEmployees();
        }
        public Employee GetSeEmployee(int serial)
        {
            return this.employeeDataAccess.GetEmployeeByID(serial);
        }

        public int UpdateExistingEmployee(int employeeId, string name, string contact, string gender, string doB, string employeeType, string hireDate, string Position, string picture)
        {
            Employee employee = new Employee() { EmployeeID = employeeId, Name = name, Contact = contact, Gender = gender,DoB = doB, EmployeeType = employeeType, HireDate = hireDate, Position = Position, Picture = picture};
            return this.employeeDataAccess.UpdateEmployee(employee);
        }
       /* public List<Employee> GetStory(string usersname)
        {
            return this.storyDataAccess.GetStoriesbyUsersname(usersname);
        }

        public List<Employee> GetSList(string usersname)
        {
            return this.storyDataAccess.GetlistbyUsersname(usersname);
        }*/
        public int RemoveEmployee(int employeeID)
        {
            return this.employeeDataAccess.DeleteEmployee(employeeID);
        }

        public int AddNewEmployee(string name, string contact, string gender, string doB, String employeeType, string hireDate, string Position, string picture)
        {

            EmployeeDataAccess employeeDataAccess = new EmployeeDataAccess();
           
            this.employeeDataAccess = new EmployeeDataAccess();
            Employee employee = new Employee() {Name = name, Contact = contact, Gender = gender, DoB = doB, EmployeeType = employeeType, HireDate = hireDate, Position = Position, Picture = picture };

            return this.employeeDataAccess.AddEmployee(employee);
        }

        public int GetEmployeeID(string name, string pos)
        {
            this.employeeDataAccess = new EmployeeDataAccess();
            return employeeDataAccess.GetEmployeeID(name,pos);
        }

        public string GetEmployeeNameByID(int id)
        {
            return employeeDataAccess.GetEmployeeNameByID(id);
        }
        public string GetEmployeePictureByID(int id)
        {
            return employeeDataAccess.GetEmployeePictureByID(id);
        }

        

    }
}
