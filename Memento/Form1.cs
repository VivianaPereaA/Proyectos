using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memento
{
    public partial class Form1 : Form
    {
        Memento m;
        public Form1()
        {
            InitializeComponent();
  
        }

        private void radRojo_CheckedChanged(object sender, EventArgs e)
        {
            grp.BackColor = Color.Red;
            if (radRojo.Checked==true)lstlhis.Items.Add("Rojo");

            m = new Memento("Rojo");
        }

        private void radAzul_CheckedChanged(object sender, EventArgs e)
        {
            grp.BackColor = Color.Blue;
            if (radAzul.Checked == true)lstlhis.Items.Add("Azul");
            m = new Memento("Azul");
        }

        private void radVerde_CheckedChanged(object sender, EventArgs e)
        {
            grp.BackColor = Color.Green;
            if (radVerde.Checked == true)lstlhis.Items.Add("Verde");
            m = new Memento("Verde");
        }

        private void btnAntes_Click(object sender, EventArgs e)
        {
            grp.BackColor = m.cambio();
            txtColor.Text = m.colorFinal();
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.Control && e.KeyCode==Keys.Z )
            {
                grp.BackColor = m.cambio();
                txtColor.Text = m.colorFinal();
            }
        }
    }
}
