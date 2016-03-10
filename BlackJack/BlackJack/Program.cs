using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class Program
    {
        static BlackJack blackJack;

        static void Main(string[] args)
        {
            blackJack = new BlackJack();

            while (true)
            {
                string key = null;
                while (Console.KeyAvailable)
                {
                    key = Console.ReadKey(true).Key.ToString();
                }
                blackJack.Update(key);
            }
            //Console.ReadLine();
        }
    }    
}


