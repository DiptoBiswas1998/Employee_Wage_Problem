using System;

namespace Welcome
{
    class Program
    {
        //Constants
        public const int IsPartTime = 0;
        public const int IsFullTime = 1;
        public const int EmpRatePerHour = 20;
        public const int NumOfWorkingDays = 20;
        public const int TotalNumOfHours = 100;
        public static int computeEmpWage()
        {
            //Welcome msg
            Console.WriteLine("Welcome to the Employee Wage Problem!");
            //Variables & Solution
            int empWage = 0;
            int empHr = 0;
            int empWageTotal = 0;
            int workingHrs = 0;
            int day = 0;
            for (day = 0; day < NumOfWorkingDays && workingHrs < TotalNumOfHours; day++)
            {
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case IsFullTime:
                        empHr = 8;
                        break;
                    case IsPartTime:
                        empHr = 4;
                        break;
                    default:
                        empHr = 0;
                        break;
                }
                workingHrs += empHr;
                empWage = empHr * EmpRatePerHour;
                empWageTotal += empWage;
            }
            Console.WriteLine("Total days worked = " + day + " Total hours worked = " + workingHrs);
            Console.WriteLine("Monthly Employee Wage = " + empWageTotal);
            return empWageTotal;
        }
        static void Main(string[] args)
        {
            computeEmpWage();
        }
    }
}