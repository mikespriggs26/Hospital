using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    abstract class Employees
    {
        protected string employeeName;
        protected string employeeNumber;
        protected string department;
        protected string specialtyArea;
        protected int numOfPatients;

        public string EmployeeName { get; set; }
        public string EmployeeNumber { get; set; }
        public string Department { get; set; }
        public string SpecialtyArea { get; set; }
        public int NumOfPatients { get; set; }

        

        public Employees(string employeeName, string employeeNumber)
        {

        }

        public int GetPaid(int hoursWorked, int payRate)
        {
            return hoursWorked * payRate;
        }


    }
}
