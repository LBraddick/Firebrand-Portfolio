using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumeratedConstants
{
    class Program
    {

        enum Color
        {
            Red,
            Orange,
            Green,
            Blue,
            Indigo,
            Violet
        }

        static void Main(string[] args)
        {
            Color favorite = Color.Green;

            switch (favorite)
            {
                case Color.Red:
                    Console.WriteLine("You choose Red");
                    break;
                case Color.Orange:
                    Console.WriteLine("You choose Orange");
                    break;
                case Color.Green:
                    Console.WriteLine("You choose Green");
                    break;
                case Color.Blue:
                    Console.WriteLine("You choose Blue");
                    break;
                case Color.Indigo:
                    Console.WriteLine("You choose Indigo");
                    break;
                case Color.Violet:
                    Console.WriteLine("You choose Violet");
                    break;
                default:
                    Console.WriteLine("You didn't choose a color");
                    break;

            }
        }
    }
}
