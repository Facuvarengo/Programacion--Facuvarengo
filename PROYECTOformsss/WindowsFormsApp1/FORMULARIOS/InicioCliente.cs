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
    public partial class InicioCliente : Form
    {
        public InicioCliente()
        {
            InitializeComponent();
        }

        private void button13_Click(object sender, EventArgs e)
        {

            VerPedidos Pedi = new VerPedidos();
            Pedi.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            Comida inicioC = new Comida();
            inicioC.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            Bebida inicioB = new Bebida();
            inicioB.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Postres inicioP = new Postres();
            inicioP.Show();
            this.Hide();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Login inicio = new Login();
            inicio.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VerPedidos Pedi = new VerPedidos();
            Pedi.Show();
            this.Hide();
        }
    }
}
