using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Console.Helpers
{
    public class AdvancedHelper
    {
        public string QuadEq(int a, int b, int c)
        {
            var response = new WebRequestHandler().Get("http://localhost/Api/Advanced/QuadEq/" + a + "/" + b + "/" + c).Result;
            return response;
        }
    }
}
