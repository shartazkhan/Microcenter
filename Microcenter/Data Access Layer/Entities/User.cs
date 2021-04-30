using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microcenter.Data_Access_Layer.Entities
{
    class User
    {
        public int EmployeeID { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Type { get; set; }
        public string Position { get; set; }
    }
}
