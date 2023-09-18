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
    public partial class AgregarProducto : Form
    {
        public AgregarProducto()
        {
            InitializeComponent();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            InicioAdministrador inicio = new InicioAdministrador();
            inicio.Show();
            this.Hide();
        }
    }
}
