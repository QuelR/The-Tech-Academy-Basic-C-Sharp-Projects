using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameParams
{
    public class DubNums
    {
        public void Nums(int num1, int num2)
        {
            Console.WriteLine("Pick a number");
            int userNum1 = Convert.ToInt32(Console.ReadLine());
            int result1 = userNum1 * 2;

            Console.WriteLine("Pick another number");
            int userNum2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(userNum1 + " X 2 equals: " + result1);

            Console.ReadLine();

        }
    }
}
