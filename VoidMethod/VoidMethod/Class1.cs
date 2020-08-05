using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Params
{
    class Addition
    {
        public void Total(int numOne, int numTwo)
        {
            int addNum1 = numOne;
            int addNum2 = numTwo;
            int total = addNum1 + addNum2;
            Console.WriteLine("Your number " + addNum1 + " plus your number " + addNum2 + " equals: " + total);
        }
    }
}
