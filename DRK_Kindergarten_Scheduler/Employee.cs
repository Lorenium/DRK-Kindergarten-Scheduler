using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DRK_Kindergarten_Scheduler
{
    public class Employee
    {
        public string Name { get; private set; }
        public Guid EmployeeID { get; private set; }

        public Employee(string name)
        {
            Name = name;
            EmployeeID = new Guid();
        }
    }
}
