using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameParams
{
    class Program
    {
        static void Main(string[] args)
        {
            DubNums dubNums = new DubNums();
            dubNums.Nums(num1: 12, num2: 10);

            Console.ReadLine();
        }
    }
}
