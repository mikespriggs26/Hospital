using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    class MedicalStaff : Employee
    {
        public MedicalStaff(string employeeName, string employeeNumber, string department, int payRate, int hoursWorked) 
            : base(employeeName, employeeNumber, department, payRate, hoursWorked)
        {
            this.employeeName = employeeName;
            this.employeeNumber = employeeNumber;
            this.department = department;
            this.payRate = payRate;
            this.hoursWorked = hoursWorked;
        }

        //public override void Employee(string employeeName, string employeeNumber, string specialtyArea, int payRate, int hoursWorked)
        //{
           
        //}
        public override void EmployeeInfo(string employeeName, string employeeNumber, string specialtyArea)
        {
            Console.WriteLine($"{employeeName}\t{employeeNumber}\t{specialtyArea}");
        }
        public override void EmployeeInfoExtra(string employeeName, string employeeNumber, string specialtyArea, bool isOperating)
        {
            Console.WriteLine($"{employeeName}\t{employeeNumber}\t{specialtyArea}\t{isOperating}");
        }
        public override int GetPaid()
        {
            int pay = payRate * hoursWorked;
             
            return pay;
            
        }
        







    }
}
