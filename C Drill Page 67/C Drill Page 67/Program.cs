using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Drill_Page_67
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.ReadLine();

            Console.WriteLine("Person 1");
            Console.ReadLine();
            Console.WriteLine("Hourly Rate?");
            string p1HourlyRate = Console.ReadLine();
            Console.WriteLine("Hours worked per week?");
            string p1HoursWorked = Console.ReadLine();

            Console.WriteLine("Person 2");
            Console.ReadLine();
            Console.WriteLine("Hourly Rate?");
            string p2HourlyRate = Console.ReadLine();
            Console.WriteLine("Hours worked per week?");
            string p2HoursWorked = Console.ReadLine();

            int p1WeekRate = Convert.ToInt32(p1HourlyRate);
            int p1WeekHours = Convert.ToInt32(p1HoursWorked);
            int p1Weekly = p1WeekRate * p1WeekHours;
            Console.WriteLine("Weekly salary of Person 1: " + p1Weekly);
            Console.ReadLine();

            int p2WeekRate = Convert.ToInt32(p2HourlyRate);
            int p2WeekHours = Convert.ToInt32(p2HoursWorked);
            int p2Weekly = p2WeekRate * p2WeekHours;
            Console.WriteLine("Weekly salary of Person 2: " + p2Weekly);
            Console.ReadLine();

            bool compWeekly = p1Weekly > p2Weekly;
            Console.WriteLine("Does Person 1 make more money than person 2?");
            Console.WriteLine(compWeekly);
            Console.ReadLine();







        }
    }
}
