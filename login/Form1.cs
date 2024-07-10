using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login
{
    public partial class Form1 : Form
    {
        public string usuario = "Cris";
        public string contraseña = "123";

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string usuarioText = textBox1.Text;
            string contraseñaText = textBox2.Text;
            
           if (usuario == usuarioText && contraseña == contraseñaText)
            {
                MessageBox.Show("Sesion iniciada correctamente");
                Bienvenido formBienvenida = new Bienvenido();
                this.Hide();
                formBienvenida.Show();
            }
           else
            {
                MessageBox.Show("Valores incorrectos, intenta de nuevo.");
            }



        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {

        }
    }
}
