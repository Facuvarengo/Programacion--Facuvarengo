using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.FORMULARIOS;

namespace WindowsFormsApp1
{
    public partial class InicioAdministrador : Form
    {
        public InicioAdministrador()
        {
            InitializeComponent();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Login inicio = new Login();
            inicio.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AgregarProducto inicio = new AgregarProducto();
            inicio.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Reportes inicio = new Reportes();
            inicio.Show();
            this.Hide();
        }
    }
}
