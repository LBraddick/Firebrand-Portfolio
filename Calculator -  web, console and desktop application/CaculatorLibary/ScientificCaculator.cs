using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Caculator.Libary
{
    public class ScientificCaculator : SimpleCaculator 
    {
        public ScientificCaculator(CaculatorParameters calcParms)
        {
            x = calcParms.X;
            y = calcParms.Y;
        }

        public ScientificCaculator()
        {
           
        }

        public int Mod (int x, int y)
        {
            return x % y;
        }
        public int Mod()
        {
            return x % y;
        }
        
        public int Factorial(int x)
        {
            int result;

            if (x == 0)
            {
                result = 1;
            }
            else
            {
                result = x * Factorial(x - 1);
            }

            return result;
        }
    }
}
