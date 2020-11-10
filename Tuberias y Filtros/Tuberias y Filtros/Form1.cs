using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tuberias_y_Filtros
{
    public partial class Form1 : Form
    {
       
        AbstractPipe p;
        public Form1()
        {
            InitializeComponent();
        }

        private void chkeliBlancos_CheckedChanged(object sender, EventArgs e)
        {
                p.add(new EliminaBlancos());
          
        }

        private void btnfiltrar_Click(object sender, EventArgs e)
        {

            txtsalida.Text = p.filtrar(txtentrada.Text);
        }

        private void chkreverse_CheckedChanged(object sender, EventArgs e)
        {
            p.add(new Reverse());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            p = new StringPipe();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            p.clear();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void macro_CheckedChanged(object sender, EventArgs e)
        {
            p.add(new macroNombre());
        }

        private void mayus_CheckedChanged(object sender, EventArgs e)
        {
            p.add(new Mayusculas());
        }

        private void minus_CheckedChanged(object sender, EventArgs e)
        {
            p.add(new Minusculas());
        }
    }
}
