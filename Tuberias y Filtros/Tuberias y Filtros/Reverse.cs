using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Tuberias_y_Filtros
{
    class Reverse:AbstractFilter
    {
 
        char[] a;

           
        public override string Filtrar(string palabra)
        {

                a = palabra.ToCharArray();
                Array.Reverse(a);
                return new string(a);
            

        }
    }
}
