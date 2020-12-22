using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

//1.Asks the user for a number.

//2. Logs that number to a text file.

//3. Prints the text file back to the user.

namespace NumberLog
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please type a number.");
            string textNum = Console.ReadLine();
            using (StreamWriter writeNum = new StreamWriter(@"C:\Users\raque\Logs\log.txt", true))
            {
                writeNum.WriteLine(textNum);
            }
            Console.WriteLine(File.ReadAllText(@"C:\Users\raque\Logs\log.txt"));
            Console.WriteLine("Thanks for your input of: " + textNum);
            Console.ReadLine();
        }
    }
}
