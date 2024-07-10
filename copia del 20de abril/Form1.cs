using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace copia_del_20de_abril
{
    public partial class Form1 : Form
    {
        private int contador = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblContador.Text = contador.ToString();
        }


        private void btnContar_Click(object sender, EventArgs e)
        {
            contador++;
            lblContador.Text = contador.ToString();
        }

        private void btnSaludar_Click(object sender, EventArgs e)
        {
            string nombre = txtName.Text;
            MessageBox.Show("Hola" + nombre);
        }
    }
}
