using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

//1.Prints the current date and time to the console.

//2. Asks the user for a number.

//3. Prints to the console the exact time it will be in X hours, X being the number the user entered in step 2.

namespace UserNumDateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime currentTime = DateTime.Now;
            Console.WriteLine(currentTime);

            Console.WriteLine("Please type a number.");
            int userNum = Convert.ToInt32(Console.ReadLine());

            DateTime addTime = currentTime.AddHours(userNum);

            Console.WriteLine(addTime);
            Console.ReadLine();
        }
    }
}
