using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login
{
    public partial class Bienvenido : Form
    {
      
        public Bienvenido()
        {
            InitializeComponent();
        }

        public int Id { get; internal set; }
        public object Nombre { get; internal set; }
        public object Apellido { get; internal set; }
        public object Curso { get; internal set; }
        public object Carnet { get; internal set; }




        private void btnPresiona_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hola Mundo ");
        }
    }
}
