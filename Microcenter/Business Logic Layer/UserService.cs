using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microcenter.Data_Access_Layer;
using Microcenter.Data_Access_Layer.Entities;

namespace Microcenter.Business_Logic_Layer
{
    class UserService
    {
        UserDataAccess userDataAccess;
        public UserService()
        {
            this.userDataAccess = new UserDataAccess();
        }

        public List<User> GetAllUser()
        {

            return this.userDataAccess.GetUsers();
        }
        public User GetUser(string username)
        {
            return this.userDataAccess.GetUsers(username);
        }

        /*public int GetUserId(string username)
        {
            return this.usersDataAccess.GetUserIds(username);
        }*/

        public User GetList(string username)
        {
            return this.userDataAccess.GetUsers(username);
        }

        public int AddNewUser(int employeeId, string name, string password, string type, string position)
        {
            User user = new User() { EmployeeID = employeeId, Name = name, Password = password, Type = type, Position = position};
            return this.userDataAccess.AddUser(user);
        }
        public int UpdateExistingUser(string name, string password, string type, string position)
        {
            User user = new User() { Name = name, Password = password, Type = type, Position = position };
            return this.userDataAccess.UpdateUser(user);
        }
        public int DeleteUser(string employeeId)
        {
            return this.userDataAccess.DeleteUser(employeeId);
        }
      /*  public List<string> GetUserNames()
        {
            return this.userDataAccess.GetUsernames();
        }*/
    }
}
