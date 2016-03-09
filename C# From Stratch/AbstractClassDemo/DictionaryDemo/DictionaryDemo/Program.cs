using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dictionary<string, string> captials = new Dictionary<string, string>();
            //captials.Add("Alabama", "Montgomery");
            //captials.Add("Alaska", "Juneau");
            //captials.Add("Arizona", "Phoenix");
            //captials.Add("Massachusetts", "Boston");
            //captials.Add("Wyoming", "Cheyenne");

            //string capitalOfMass = captials["Massachusetts"];
            //Console.WriteLine("The captial of Masschusetts is {0}", capitalOfMass);

            var theStates = State.GetStates();
           // string capitalOfAlaska = theStates["Alaska"].Capital;
            Console.WriteLine("The capital of Alaska is {0}, its population is {1} and it is {2} square miles",
                theStates.capital, theStates.pop, theStates.size);

            Console.ReadLine();
        }
    }
}
