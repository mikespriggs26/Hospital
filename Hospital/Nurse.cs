using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    class Nurse : Employee
    {
        public Nurse(string employeeName, string employeeNumber, string department, int payRate, int hoursWorked) 
            : base(employeeName, employeeNumber, department, payRate, hoursWorked)
        {
            this.employeeName = employeeName;
            this.employeeNumber = employeeNumber;
            this.department = department;
            this.payRate = payRate;
            this.hoursWorked = hoursWorked;
        }



        //public Nurse(string employeeName, string employeeNumber, string numOfPatients, int payRate, int hoursWorked)
        //{

        //}
        public override void EmployeeInfo(string employeeName, string employeeNumber, string numOfPatients)
        {
            Console.WriteLine($"{employeeName}\t{employeeNumber}\t{numOfPatients}");
        }
        public override void EmployeeInfoExtra(string employeeName, string employeeNumber, string department, bool isOperating)
        {
            Console.WriteLine($"{employeeName}\t{employeeNumber}\t{department}\t{isOperating}");
        }
        public override int GetPaid()
        {
            int pay = payRate * hoursWorked;
            return pay;
        }
    }
}
