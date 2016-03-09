using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Caculator.Libary
{
    public class CaculatorParameters
    {
        private int x = 0, y = 0;

        public int X
        {
            get
            {
                return x;
            }
            set
            {
                x = value;
            }
        }
        public int Y
        {
            get
            {
                return y;
            }
            set
            {
                // Check to ensure y is never zero
                if (value != 0)
                {
                    y = value;
                }
             
                else
                {
                    y = 1;
                }
            }
        }
    }
}
