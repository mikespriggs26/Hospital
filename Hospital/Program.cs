using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isOperating = default(bool);
            bool isOnThePhone = default(bool);
            bool isSweeping = default(bool);

            //mvslta
            
            MedicalStaff Michael = new MedicalStaff("Michael", "234", "Heart", 200, 40);
            MedicalStaff Vincent = new MedicalStaff("Vincent", "645", "Brain", 250, 35);
            Nurse Sonny = new Nurse("Sonny", "789", "6", 20, 40);
            SupportStaff Luca = new SupportStaff("Luca", "375", "Business", 15, 40);
            SupportStaff Tom = new SupportStaff("Tom", "951", "Office", 17, 32);
            SupportStaff Anthony = new SupportStaff("Anthony", "123", "Maint.", 11, 40);


            Console.WriteLine("Is Vincent operating?");
            string vincentWorking = Console.ReadLine().ToLower();
            if (vincentWorking == "yes")
            {
                isOperating = true;
            }
            else
            {
                isOperating = false;
            }
            Console.WriteLine("Is Tom on the phone?");
            string tomWorking = Console.ReadLine().ToLower();
            if (tomWorking == "yes")
            {
                isOnThePhone = true;
            }
            else
            {
                isOnThePhone = false;
            }
            Console.WriteLine("Is Anthony sweeping?");
            string anthonySweeping = Console.ReadLine().ToLower();
            if (anthonySweeping == "yes")
            {
                isSweeping = true;
            }
            else
            {
                isSweeping = false;
            }



            Michael.EmployeeInfo("Michael", "234", "Heart");
            Vincent.EmployeeInfoExtra("Vincent", "645", "Brain", isOperating);
            Sonny.EmployeeInfo("Sonny", "789", "6");
            Luca.EmployeeInfo("Luca", "375", "Business");
            Tom.EmployeeInfoExtra("Tom", "951", "Office", isOnThePhone);
            Anthony.EmployeeInfoExtra("Anthony", "123", "Maint.", isSweeping);
            Console.WriteLine();

            if (vincentWorking == "yes")
            {
                Console.WriteLine("Vincent is operating.");
            }
            else
            {
                Console.WriteLine("Vincent is not operating.");
            }
           
            if (tomWorking == "yes")
            {
                Console.WriteLine("Tom is on the phone."); 
            }
            else
            {
                Console.WriteLine("Tom is not on the phone."); 
            }
            
            if (anthonySweeping == "yes")
            {
                Console.WriteLine("Anthony is sweeping."); 
            }
            else
            {
                Console.WriteLine("Anthony is not sweeping");
            }
            Console.WriteLine();

            Console.WriteLine("Do you want to do payroll?");
            string userInput = Console.ReadLine().ToLower();
            if(userInput == "yes")
            {
                Console.WriteLine();
                Console.WriteLine("Michael will be paid $" + Michael.GetPaid());
                Console.WriteLine("Vincent will be paid $" + Vincent.GetPaid());
                Console.WriteLine("Sonny will be paid $" + Sonny.GetPaid());
                Console.WriteLine("Luca will be paid $" + Luca.GetPaid());
                Console.WriteLine("Tom will be paid $" + Tom.GetPaid());
                Console.WriteLine("Anthony will be paid $" + Anthony.GetPaid());
                Console.WriteLine();
            }
            else
            {
                Environment.Exit(0);
            }
            
           

       

            









            //SupportStaff Luca = new SupportStaff("Luca", "375", "Business");
            //SupportStaff Tom = new SupportStaff("Tom", "951", "Office");
            //SupportStaff Anthony = new SupportStaff("Anthony", "123", "Maintenance");
            //MedicalStaff Michael = new MedicalStaff("Michael", "234", "Heart");
            //MedicalStaff Vincent = new MedicalStaff("Vincent", "645", "Brain");
            //Nurse Sonny = new Nurse("Sonny", "789", "6");

            //Vincent.VinceStatus( isOperating);


        }
    }
}
