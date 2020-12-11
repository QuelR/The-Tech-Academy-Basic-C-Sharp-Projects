using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//1.Create an enum for the days of the week.

//2.Prompt the user to enter the current day of the week.

//3.Assign the value to a variable of that enum data type you just created.

//4. Wrap the above statement in a try/catch block and have it print "Please enter an actual day of the week." to the console if an error occurs.

namespace WeekdayEnums
{
    class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter the current day of the week.");
                string userDay = Console.ReadLine();

                if (Enum.TryParse(userDay, out DaysOfTheWeek dayNum))
                {
                    Console.WriteLine("Today is " + dayNum);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
        public enum DaysOfTheWeek
        {
            Sunday=1,Monday=2,Tuesday=3,Wednesday=4,Thursday=5,Friday=6,Saturday=7
        }
    }
}









//if (Enum.IsDefined(typeof(DaysOfTheWeek), dayNum))
//{
//    DaysOfTheWeek weekDay = (DaysOfTheWeek)dayNum;
//}
//foreach (var value in Enum.GetValues(typeof(DaysOfTheWeek)))
//{
//    object nextDay = Convert.ToString(value);
//}
//DaysOfTheWeek daysOfWeek = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), userDay);

//Console.WriteLine("Tomorrow is " + userDay);

//switch (DaysOfTheWeek) 
//{
//    case Monday:
//        Console.WriteLine("");
//        break;
//}