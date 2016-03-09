using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Caculator.Libary
{
    public class Triangle : Shape
    {
        public override int CalculateArea(int width, int height)
        {
            return (width * height) / 2;
        }
    }
}
