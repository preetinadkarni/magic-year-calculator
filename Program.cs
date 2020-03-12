using System;

namespace Magic_Year_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n~~~");
            Console.WriteLine("Welcome to the magic year calculator!\n");
            Console.Write("Please input your name: ");
            string name = Console.ReadLine();
            Console.Write("Please input your surname: ");
            string surname = Console.ReadLine();
            Console.Write("Please enter your annual salary: ");
            double annualSalary = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter your work start year: ");
            int startYear = Convert.ToInt32(Console.ReadLine());

            // calculate monthly salary and magic year
            double monthlySalary = annualSalary/12;
            double roundUpMomnthlySalary = Math.Round(monthlySalary,MidpointRounding.AwayFromZero);
;
            int magicYear = startYear + 65;
            
            // output
            Console.WriteLine("\nYour magic age details are:\n");
            Console.WriteLine("Name: " +  name + " " + surname);
            Console.WriteLine("Monthly Salary: " + roundUpMomnthlySalary);
            Console.WriteLine("Magic Year:" + magicYear);
            Console.WriteLine("~~~\n");
        }
    }
}
