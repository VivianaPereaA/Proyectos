using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memento
{
    class Memento
    {
        private static Stack<string> estado = new Stack<string>();
        private string color;

        public Memento(string state)
        {
            estado.Push(state);
        }
        public string getEstado()
        {
            if (estado.Count > 1)
            {
                estado.Pop();
                return estado.Pop();
            }
            else
            {
                return null;
            }
        }

        public  Color cambio()
        {

            switch (this.getEstado())
            {
                case "Rojo":
                    color = "Rojo";
                    return Color.Red;

                case "Azul":
                    color = "Azul";
                    return Color.Blue;
                case "Verde":
                    color = "Verde";
                    return Color.Green;
                default:
                    color = "No hay más";
                    return Color.Transparent;

            }
        }
        public string colorFinal()
        {
            return color;
        }
    }
}
