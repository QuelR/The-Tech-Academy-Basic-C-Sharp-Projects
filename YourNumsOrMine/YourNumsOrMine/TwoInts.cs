using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YourNumsOrMine
{
    class TwoInts
    {

        public int Numbers(int numOne, string stringNum)
        {
            int combo;

            if (stringNum == "")
            {
                combo = numOne;
            }
            
            else 
            {
                int numTwo = Convert.ToInt32(stringNum);
                combo = numOne + numTwo;
            }

            return combo;
        }
    }
}

