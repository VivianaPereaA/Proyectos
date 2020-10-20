using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronCadena
{
    public class Handler1000 : Handler
    {
        public Handler1000(Handler next)
        {
            nextHandler = next;
        }
        public override double HandlerRequest(double x)
        {
            if (x >= 0 && x <= 999)
            {
                return x * 0.01;
            }
            else
            {
                return nextHandler.HandlerRequest(x);
            }
        }
    }
}
