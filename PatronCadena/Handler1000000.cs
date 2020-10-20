using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronCadena
{
    public class Handler1000000 : Handler
    {
        public Handler1000000(Handler next)
        {
            nextHandler = next;
        }
        public override double HandlerRequest(double x)
        {
            if (x >= 1000000)
            {
                return x * 0.04;
            }
            else
            {
                return nextHandler.HandlerRequest(x);
            }
        }
    }
}
