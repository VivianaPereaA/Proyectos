using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronCadena
{
   public abstract  class Handler
    {
        public Handler nextHandler;

        public abstract double HandlerRequest(double x);
    }
}
