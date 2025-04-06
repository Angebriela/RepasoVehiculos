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
    public partial class FormVehiculos : Form
    {
        List<Vehiculo> vehiculos = new List<Vehiculo>();
        public FormVehiculos()
        {
            InitializeComponent();
        }

        private void Mostrar()
        {
            VehiculoArchivo vehiculoArchivo = new VehiculoArchivo();
            vehiculos = vehiculoArchivo.Leer("../../Vehiculos.json");
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = vehiculos;
            dataGridView1.Refresh();
        }
        private void buttonMenu_Click(object sender, EventArgs e)
        {
            Form1 formuMenu = new Form1();
            formuMenu.Show();
            this.Hide();
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            if (vehiculos.Any(v => v.Placa == textBoxPlaca.Text))
            {
                MessageBox.Show("¡Ya existe un vehículo registrado con esta placa!");
                return; // Sale de la función sin guardar
            }


            Vehiculo vehiculo = new Vehiculo();
            vehiculo.Placa = textBoxPlaca.Text;
            vehiculo.Marca = textBoxMarca.Text;
            vehiculo.Modelo = textBoxModelo.Text;
            vehiculo.Color = textBoxColor.Text;
            vehiculo.PrecioKilometro = decimal.Parse(maskedTextBoxPrecio.Text);
            vehiculos.Add(vehiculo);

            VehiculoArchivo vehiculoArchivo = new VehiculoArchivo();
            vehiculoArchivo.Guardar("../../Vehiculos.json", vehiculos);//Funcion guardar de clase VehiculoArchivo
            Mostrar();

            MessageBox.Show("¡Vehículo registrado correctamente!");

        }

        private void FormVehiculos_Load(object sender, EventArgs e)
        {
            Mostrar();
        }
    }
}
