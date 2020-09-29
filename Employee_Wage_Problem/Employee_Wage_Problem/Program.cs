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
            const int IsFullTime = 1;
            const int IsPartTime = 0;
            const int EmpRatePerHour = 20;
            //Variables & Calculation using switch
            int empWage = 0;
            int empHr = 0;
            int flag = 0;
            Random random = new Random();
            int empCheck = random.Next(0, 3);
            switch (empCheck)
            {
                case IsPartTime:
                    empHr = 4;
                    Console.WriteLine("Part time Employee is present");
                    break;
                case IsFullTime:
                    empHr = 8;
                    Console.WriteLine("Full time Employee is present");
                    break;
                default:
                    Console.WriteLine("Neither Full Time nor Part time Employee is present!");
                    flag = 1;
                    break;
            }
            if (flag == 0)
            {
                empWage = empHr * EmpRatePerHour;
                Console.WriteLine("Employee Wage = " + empWage);
            }
        }
    }
}