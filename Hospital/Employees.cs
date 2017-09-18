using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    abstract class Employee
    {
        protected string employeeName;
        protected string employeeNumber;
        protected string department;
        protected string specialtyArea;
        protected int numOfPatients;
        protected bool isOperating;
        protected int payRate;
        protected int hoursWorked;

        public string EmployeeName { get; set; }
        public string EmployeeNumber { get; set; }
        public string Department { get; set; }
        public string SpecialtyArea { get; set; }
        public int NumOfPatients { get; set; }
        public bool IsOperating { get; set; }
        public int PayRate { get; set; }
        public int HoursWorked { get; set; }

        public Employee(string employeeName, string employeeNumber, string department, int payRate, int hoursWorked)
        {

        }

        public abstract void EmployeeInfo(string employeeName, string employeeNumber, string department);

        public abstract void EmployeeInfoExtra(string employeeName, string employeeNumber, string specialtyArea, bool isOperating);

        public abstract int GetPaid();




    }
}
