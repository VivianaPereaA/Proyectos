using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuberias_y_Filtros
{
    class StringPipe:AbstractPipe
    {

        public override void add(AbstractFilter F)
        {
            filtros.Add(F);
        }

        public override void clear()
        {
            filtros.Clear();
        }

        public override string filtrar(string input)
        {
            string temp = input;
            foreach (AbstractFilter item in filtros)
            {
                temp = item.Filtrar(temp);
            }
            return temp;
        }
    }
}
