using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronCadena
{
    public class Handler10000 : Handler
    {
        public Handler10000(Handler next)
        {
            nextHandler = next;
        }
        public override double HandlerRequest(double x)
        {
            if(x>=1000 && x<= 9999)
            {
                return x * 0.02;
            }
            else
            {
                return nextHandler.HandlerRequest(x);
            }
        }
    }
}
