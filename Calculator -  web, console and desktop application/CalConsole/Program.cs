using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab.Caculator.Libary;

namespace CalConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            string sOpt = "";
            
            CaculatorParameters parms = new CaculatorParameters();

            while (true)
            {
                try
                {                                     // Try statement to handle exceptions
                    sOpt = Console.ReadLine();               // Reads user intput as a string
                   parms.X = int.Parse(Console.ReadLine());      // Reads user intput as a int 
                   parms.Y = int.Parse(Console.ReadLine());
                }
                catch (FormatException e)                   // To catch varriable and handle an exception of user error
                {
                    Console.WriteLine("Incorrect Paramater!");      // Prints an user error message 
                    parms.X = 0;
                    parms.Y = 0;
                }

                ScientificCaculator calc = new ScientificCaculator(parms);
                switch (sOpt)                           // Caclator logic  - switch statement
                {
                    case "Add":
                        Console.WriteLine(calc.Add());
                        break;                         // Use breaks to break down code between each case
                    case "Sub":
                        Console.WriteLine(calc.Sub());
                        break;
                    case "Mul":
                        Console.WriteLine(calc.Mul());
                        break;
                    case "Div":
                        Console.WriteLine(calc.Div());
                        break;
                    case "Mod":
                        Console.WriteLine(calc.Mod());
                        break;
                    case "Fact":
                        Console.WriteLine(calc.Factorial(parms.X));
                        break;
                    default:
                        Console.WriteLine("Unknown operation!");   // Handle unknow opperations in a sensible mannor. 
                        break;                                     // Whether case sensitive or incorrect
                }
            }
        }
    }
}
