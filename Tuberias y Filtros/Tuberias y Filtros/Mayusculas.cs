using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuberias_y_Filtros
{
    class Mayusculas:AbstractFilter 
    {
        public override string Filtrar(string palabra)
        {
            return palabra.ToUpper();

        }
    }
}
