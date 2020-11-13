using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Pregunta4
{
 
    class Vector : AbstractFilter
    {
        string texto = "";
        public override string filtrar(string palabra)
        {
            Regex regex = new Regex("[(,]*/d+(.+/d+)?[,)]*");
            MatchCollection r = regex.Matches(palabra);
            foreach (var item in r)
            {
                texto += r.ToString() + " ";
            }
            return texto;

        }
    }
}
