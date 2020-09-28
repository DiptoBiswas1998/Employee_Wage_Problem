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
            int IsPartTime = 0;
            int EmpRatePerHour = 20;
            //Variables & Calculation
            int empWage = 0;
            int empHr = 0;

            Random random = new Random();
            int empCheck = random.Next(0, 3);
            if (empCheck == IsPartTime)
            {
                Console.WriteLine("Part time Employee is Present.");
                empHr = 4;
            }
            else if (empCheck == IsFullTime)
            {
                Console.WriteLine("Full time Employee is Present.");
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