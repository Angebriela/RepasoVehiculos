using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RepasoVehiculos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonCliente_Click(object sender, EventArgs e)
        {
            FormCliente formuCliente = new FormCliente();
            formuCliente.Show();
            this.Hide();
        }

        private void buttonVehiculos_Click(object sender, EventArgs e)
        {
            FormVehiculos formuVehiculos = new FormVehiculos();
            formuVehiculos.Show();
            this.Hide();
        }

        private void buttonAlquiler_Click(object sender, EventArgs e)
        {
            FormAlquiler formuAlquiler = new FormAlquiler();
            formuAlquiler.Show();
            this.Hide();
        }

        private void buttonReporte_Click(object sender, EventArgs e)
        {
            FormReporte formuReporte = new FormReporte();
            formuReporte.Show();
            this.Hide();
        }
    }
}
