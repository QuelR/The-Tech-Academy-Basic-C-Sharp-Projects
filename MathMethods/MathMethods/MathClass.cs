using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathMethods
{
    class MathClass
    {
        public int Adding(int addNum)
        {
            return addNum + 100;
        }

        public int Divide(decimal divNum)
        {
            decimal mathOp = divNum / 2;
            int result = Convert.ToInt32(mathOp);
            return result;
        }

        public int Third(string thirdNum)
        {
            int tNum = Convert.ToInt32(thirdNum);
            int tNumTotal = tNum * 42;
            return tNumTotal;
        }
    }
}
