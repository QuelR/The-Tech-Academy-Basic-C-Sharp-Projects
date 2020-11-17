using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathMethods
{
    class MathClass
    {
        public void Adding(int addNum)
        {
            Console.WriteLine(addNum + 100);
        }

        public void Divide(decimal divNum)
        {
            Console.WriteLine(divNum / 2);
        }

        public void Third(string thirdNum)
        {
            int tNum = Convert.ToInt32(thirdNum);
            int tNumTotal = tNum * 42;
            Console.WriteLine(tNumTotal);
        }
    }
}
