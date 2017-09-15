using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    class SupportStaff
    {
        
        protected string department;

        public SupportStaff(string employeeName, string employeeNumber, string department)
        {
            Console.WriteLine(employeeName + employeeNumber + department);
            
        }
    }
}
