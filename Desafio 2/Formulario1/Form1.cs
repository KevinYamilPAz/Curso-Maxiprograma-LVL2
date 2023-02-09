using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulario1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TBedad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 59) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void BTcarga_Click(object sender, EventArgs e)
        {
            int cont = 0;
            if (TBnombre.Text == "")
            {
                TBnombre.BackColor = Color.Red;
            }
            else
            {
                TBnombre.BackColor = System.Drawing.SystemColors.Control;
                cont += 1;
            }
            if (TBapellido.Text == "")
            {
                TBapellido.BackColor = Color.Red;
            }
            else
            {
                TBapellido.BackColor = System.Drawing.SystemColors.Control;
                cont += 1;
            }
            if (TBedad.Text == "")
            {
                TBedad.BackColor = Color.Red;
            }
            else
            {
                TBedad.BackColor = System.Drawing.SystemColors.Control;
                cont += 1;
            }
            if (TBdireccion.Text == "")
            {
                TBdireccion.BackColor = Color.Red;
            }
            else
            {
                TBdireccion.BackColor = System.Drawing.SystemColors.Control;
                cont += 1;
            }
            if (cont == 4)
            {
                string Nombre = TBnombre.Text;
                string Apellido = TBapellido.Text;
                //int Edad = int.Parse(TBedad.Text);
                string Edad = TBedad.Text;
                string Direccion = TBdireccion.Text;
                LVdatos.Clear();
                LVdatos.Items.Add(Nombre + " " + Apellido);
                LVdatos.Items.Add("Edad: " + Edad);
                LVdatos.Items.Add("Direccion: " + Direccion);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BTcancelar_Click(object sender, EventArgs e)
        {
            LVdatos.Clear();
        }
    }
}
