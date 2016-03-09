using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSSFSDemo6
{
    class Program
    {
        static void Main(string[] args)
        {
            // LINQ Orderby and Grouping
            //var primes = new List<int> { 1, 2, 3, 5, 7, 11, 13, 17, 19, 21 };
            //var query = from val in primes
            //            where val < 13
            //            select val;
            //foreach (var val in query)
            //    Console.WriteLine(val);

            //var methodQuery = primes.Where(x => x < 13);
            //foreach (var val in methodQuery)
            //    Console.WriteLine(val);



            // LINQ Contains and Any
            //var query = from method in typeof(double).GetMethods()
            //            orderby method.Name
            //            group method by method.Name into groups
            //            select new { MethodName = groups.Key, NumberOfOverloads = groups.Count() };

            //foreach (var item in query)
            //    Console.WriteLine(item);



            //LINQ Contains and Any
            //var listOne = Enumerable.Empty<int>();
            //var listTwo = Enumerable.Range(1, 20);

            //bool listOneEmpty = listOne.Any();
            //bool listTwoEmpty = listTwo.Any();

            //Console.WriteLine("list one has members? " + listOneEmpty + 
            //    " list two has members? " + listTwoEmpty);

            //Console.WriteLine("listTwo has 12? " + listTwo.Contains(12) +
            //    "listTwo has 30? " + listTwo.Contains(30));



            //LINQ Take
            //var bigList = Enumerable.Range(1, 20);
            //var littleList = bigList.Take(5).Select(x => x * 10);
            //foreach (var i in littleList)
            //    Console.WriteLine(i);



            //LINQ Zip
            string[] postalCode = { "AL", "AK", "AZ", "AR", "CA",
                                     "CO", "CT", "DE", "FL" };
            string[] states = { "Alabama", "Alaska", "Arizona", "Arkansas",
                                "California", "Colorodo", "Connecticut",
                                "Deleware", "Florida"};

            var statesWithCodes = postalCode.Zip(states, (code, state) =>
                 code + ": " + state);

            foreach (var stateWithCode in statesWithCodes)
            {
                Console.WriteLine(stateWithCode);
            }

        
            Console.ReadLine();
        }
    }
}
