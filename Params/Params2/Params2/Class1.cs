using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Params2
{
    class Magic
    {
        public int Total(int numOne, string numTwo)
        {
            int combo;
            if (numTwo == "")
            {
                combo = numOne;

            }
            else
            {
                int numThree = Convert.ToInt32(numTwo);
                combo = numOne + numThree;
            }

            return combo;
        }
    }
}
