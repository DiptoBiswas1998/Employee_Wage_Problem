using System;

namespace Welcome
{
    class Program
    {
        static void Main(string[] args)
        {
            //Welcome msg
            Console.WriteLine("Welcome to the Employee Wage Problem!");
            //Check
            int IsFullTime = 1;
            Random random = new Random();
            int empCheck = random.Next(0, 2);
            if (empCheck == IsFullTime)
            {
                Console.WriteLine("Employee is Present.");
            }
            else
            {
                Console.WriteLine("Employee is Absent!");
            }
        }
    }
}