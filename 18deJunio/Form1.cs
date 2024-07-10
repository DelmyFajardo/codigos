using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _18deJunio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ocultarMenu();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelmenu_Paint(object sender, PaintEventArgs e)
        {

        }
       
        private void ocultarMenu()
        {
            panelsubAcceso.Visible = false;
            panelsubmedicos.Visible = false;
            panelsubpacientes.Visible = false;
        } 
        private void mostrarSubMenu(Panel menu)
        {
            ocultarMenu();
            menu.Visible = true;
        }

        private void btnAcceso_Click(object sender, EventArgs e)
        {
            mostrarSubMenu(panelsubAcceso);

          
        }

        private void button19_Click(object sender, EventArgs e)
        {
            mostrarSubMenu(panelsubmedicos);

        }

        private void button29_Click(object sender, EventArgs e)
        {
            mostrarSubMenu(panelsubpacientes);
        }

      
    }
}
