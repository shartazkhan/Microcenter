using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microcenter.Data_Access_Layer;
using Microcenter.Data_Access_Layer.Entities;


namespace Microcenter.Business_Logic_Layer
{
    class LoginService
    {
        LoginDataAccess loginDataAccess;
        public LoginService()
        {
            this.loginDataAccess = new LoginDataAccess();
        }
        public string LoginValidation(int employeeID, string password)
        {
            User user = new User()
            {
                EmployeeID = employeeID,
                Password = password
            };
            return loginDataAccess.UserLoginValidation(user);
        }
    }
}
