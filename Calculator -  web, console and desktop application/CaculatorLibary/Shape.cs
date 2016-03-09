using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Caculator.Libary
{
    public abstract class Shape : IComparable<Shape>   // Interfact IComparable comparison
    {
        private int area;

        public int Area
        {
            get
            {
                return area;
            }
        }

        public virtual int CalculateArea(int width, int height)
        {
            area = width * height;

            return area;
        }

        public int CompareTo(Shape other)
        {
            return this.Area.CompareTo(other.Area);
        }
    }
}
