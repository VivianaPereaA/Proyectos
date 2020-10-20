using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronCadena
{
    public class Handler100000 : Handler
    {
        public Handler100000(Handler next)
        {
            nextHandler = next;
        }
        public override double HandlerRequest(double x)
        {
           if(x>=100000 && x<=99999)
            {
                return x * 0.03;
            }
            else
            {
                return nextHandler.HandlerRequest(x);
            }
        }
    }
}
