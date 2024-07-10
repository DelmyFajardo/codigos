using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora_del_20
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtNUMER01_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNUMERO2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSUMAR_Click(object sender, EventArgs e)
        {
            int nu1 = int.Parse(txtNUMER01.Text.ToString());
            int nu2 = int.Parse(txtNUMERO2.Text.ToString());


            
        }

        private void txtTOTAL_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
