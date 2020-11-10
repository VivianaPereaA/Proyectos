using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Tuberias_y_Filtros
{
  abstract  class AbstractPipe
    {
        abstract public void add(AbstractFilter F);
        abstract public string filtrar(string input);
        protected List<AbstractFilter> filtros;

        public AbstractPipe()
        {
            filtros = new List<AbstractFilter>();
        }
        abstract public void clear();

    }
}
