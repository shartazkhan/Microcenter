using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microcenter.Data_Access_Layer.Entities
{
    class Employee
    {
        public int EmployeeID { get; set; }
        public string Name { get; set; }
        public int Contact { get; set; }
        public string Gender { get; set; }
        public string DoB { get; set; }
        public int EmployeeType { get; set; }
        public string HireDate { get; set; }
        public string Position { get; set; }
        public string Picture { get; set; }

    }
}
