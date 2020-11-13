using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Pregunta4
{
    public partial class Form1 : Form
    {
        AbstractFilter a;
        public Form1()
        {
            InitializeComponent();
        }

        private void btndiv_Click(object sender, EventArgs e)
        {
            a = new Div();
            txtres.Text = a.filtrar(txtTexto.Text);
        }

        private void txtTexto_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnVector_Click(object sender, EventArgs e)
        {
            a = new Vector();
            txtres.Text = a.filtrar(txtTexto.Text);

        }
    } 
}
