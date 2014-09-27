using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp
{
    class Employee
    {
        public string name;
       public double basicAmount;
        public double houseRent;

        public double medicalAllowance;
        public double Calculate()
        {
            double totalSalary = (basicAmount+((basicAmount*houseRent)/100)+((basicAmount*medicalAllowance)/100));
            return totalSalary;
        }
    }
}
