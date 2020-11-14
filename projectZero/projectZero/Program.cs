using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectZero
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> intList = new List<int>{ 10, 100, 1000 };
            while (true)
            {
                try
                {
                    Console.WriteLine("Enter a number.");
                    int userNum = Convert.ToInt32(Console.ReadLine());

                    for (int i = 0; i < intList.Count; i++)
                    {
                        int divNum = intList[i] / userNum;
                        Console.WriteLine("\n" + intList[i] + " divided by " + userNum + " is: " + divNum);                        
                    }
                    Console.ReadLine();
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please enter a number value.");
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Please don't use zero.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    Console.ReadLine();
                }
            }
        }
    }
}
