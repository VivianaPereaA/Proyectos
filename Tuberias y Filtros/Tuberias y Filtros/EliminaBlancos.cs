using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Tuberias_y_Filtros
{
    class EliminaBlancos:AbstractFilter
    {

        public override string Filtrar(string palabra)
        {
                return Regex.Replace(palabra, " +", " ");

        }
    }
}
