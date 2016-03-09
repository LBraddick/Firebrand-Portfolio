using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Caculator.Libary
{
    public class SimpleCaculator
    {
        protected int x = 0, y = 0;

        public SimpleCaculator()  // place holder does nothing
        {

        }
        public SimpleCaculator(int xParm, int yParm)
        {
            x = xParm;
            y = yParm;
        }
     
        public SimpleCaculator(CaculatorParameters calcParms)
        {
            x = calcParms.X;
            y = calcParms.Y;
        }


        public int Add(int x, int y)                 //Add method
        {
            return x + y;
        }
        public int Add()                 //Add method
        {
            return x + y;
       }
       public int Sub(int x, int y)              // Sub method
        {
            return x - y;
        }
        public int Sub()              // Sub method
         {
           return x - y;
          }
      public int Div(int x, int y)               //Divide method
        {
            int result = 0;

            try                                        // To get program to not crash over y parameter being zero
            {                                          // Execption handling
                result = x / y;
            }
            catch (DivideByZeroException e)             // Catch the 0 the user has entered 
            {
                result = 0;
             }
            
            return result;                              // Returns the result back to where is called from  
        }
          public int Div()               //Divide method
         {
           int result = 0;

           try                                        // To get program to not crash over y parameter being zero
        {                                          // Execption handling
            result = x / y;
        }
            catch (DivideByZeroException e)             // Catch the 0 the user has entered 
      {
                result = 0;   // Inform the user the that the y parameter cant be 0
            }
           
          return result;                              // Returns the result back to where is called from  
         }

       public int Mul(int x, int y)                  //Multiple method
        {
            return x * y;
        }

        public int Mul()                  //Multiple method
           {
              return x * y;
           }

    }
}
