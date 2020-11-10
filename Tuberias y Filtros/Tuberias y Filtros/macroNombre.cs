using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Tuberias_y_Filtros
{
    class macroNombre:AbstractFilter 
    {
        public override string Filtrar(string palabra)
        {
            return Regex.Replace(palabra, "@vcpa", "Viviana Cristina Perea Apaza");
        }
    }
}
