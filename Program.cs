
using System;
namespace ProgramToCheckLeapYear
{
    class Program
    {
        static void Main(string[] args)
        {
            int year;
            Console.Write("Enter year :");
            year = Convert.ToInt32(Console.ReadLine());
            if (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0))
                Console.WriteLine("Year is Leap Year");
            else
                Console.WriteLine("Year is not a Leap Year");
                Console.ReadKey();
        }
    }
}

