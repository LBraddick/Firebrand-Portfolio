using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Services;
using Lab.Caculator.Libary;

namespace CaculatorWebApplication
{
    /// <summary>
    /// Summary description for CaculatorWebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]

    public class CaculatorWebService : System.Web.Services.WebService
    {
        private ScientificCaculator calc;

        public CaculatorWebService()
        {
            calc = new ScientificCaculator();
        }

        [WebMethod]                                     // exposes the class to the internet

        public int Add(int x, int y)
        {
            return calc.Add(x,y);
        }

        [WebMethod]
        public int Sub(int x, int y)
        {
            return calc.Sub(x, y);
        }

        [WebMethod]
        public int Div(int x, int y)
        {
            return calc.Div(x, y);
        }

        [WebMethod]
        public int Mul(int x, int y)
        {
            return calc.Mul(x, y);
        }

        [WebMethod]
        public int Mod(int x, int y)
        {
            return calc.Mod(x, y);
        }

        [WebMethod]
        public int Factorial(int X)
        {
            return calc.Factorial(X);
        }
    }
}
