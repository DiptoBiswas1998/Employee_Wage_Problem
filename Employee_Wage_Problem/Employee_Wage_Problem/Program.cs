using System;

namespace Welcome
{
    class Program
    {
        static void Main(string[] args)
        {
            //Welcome msg
            Console.WriteLine("Welcome to the Employee Wage Problem!");
            //Constants
            int IsFullTime = 1;
            int EmpRatePerHour = 20;
            //Variables
            int empWage = 0;
            int empHr = 0;
            //Calculation
            Random random = new Random();
            int empCheck = random.Next(0, 2);
            if (empCheck == IsFullTime)
            {
                Console.WriteLine("Employee is Present.");
                empHr = 8;
            }
            else
            {
                Console.WriteLine("Employee is Absent!");
                empHr = 0;
            }
            empWage = empHr * EmpRatePerHour;
            Console.WriteLine("Employee Wage = " + empWage);
        }
    }
}