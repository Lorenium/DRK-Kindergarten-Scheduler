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
        public Guid ID { get; private set; }

        public Employee(string name)
        {
            Name = name;
            ID = Guid.NewGuid();
        }
    }
}
