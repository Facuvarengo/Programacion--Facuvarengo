using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.FORMULARIOS
{
    public partial class Comida : Form
    {
        public Comida()
        {
            InitializeComponent();
        }

        private void button14_Click(object sender, EventArgs e)
        {

            InicioCliente inicio = new InicioCliente();
            inicio.Show();
            this.Hide();
        }
    }
}
