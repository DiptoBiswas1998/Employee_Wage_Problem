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
        static void Main(string[] args)
        {
            //Welcome msg
            Console.WriteLine("Welcome to the Employee Wage Problem!");
            //Variables & Solution
            int empWage = 0;
            int empHr = 0;
            int empWageTotal = 0;

            for (int day = 0; day < NumOfWorkingDays; day++)
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
                empWage = empHr * EmpRatePerHour;
                empWageTotal += empWage;
                Console.WriteLine("Employee Wage = " + empWage + " on day " + (day + 1));
            }
            Console.WriteLine("Monthly Employee Wage = " + empWageTotal);

        }
    }
}