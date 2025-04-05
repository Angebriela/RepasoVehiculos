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
    public partial class FormAlquiler : Form
    {
        List<AlquilerVehiculos> alquilerVehiculos = new List<AlquilerVehiculos>();
        public FormAlquiler()
        {
            InitializeComponent();
        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            Form1 formuMenu = new Form1();
            formuMenu.Show();
            this.Hide();
        }

        private void Mostrar()
        {
            AlquileresArchivo alquileresArchivo = new AlquileresArchivo();
            alquilerVehiculos = alquileresArchivo.Leer("../../Alquileres.json");
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = alquilerVehiculos;
            dataGridView1.Refresh();
        }

        private void FormAlquiler_Load(object sender, EventArgs e)
        {
            List<Clientes> clientes = new List<Clientes>();
            ClientesArchivo clientesArchivo = new ClientesArchivo();
            clientes = clientesArchivo.Leer("../../Clientes.json");
            comboBoxNit.DisplayMember = "Nit";
            comboBoxNit.ValueMember = "Nombre";
            comboBoxNit.DataSource = clientes;

            List<Vehiculo> vehiculos = new List<Vehiculo>();
            VehiculoArchivo vehiculoArchivo = new VehiculoArchivo();
            vehiculos = vehiculoArchivo.Leer("../../Vehiculos.json");
            comboBoxPlaca.DisplayMember = "Placa";
            comboBoxPlaca.ValueMember = "Marca";
            comboBoxPlaca.DataSource = vehiculos;

            Mostrar();
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            AlquilerVehiculos alquilerVehiculo = new AlquilerVehiculos();
            alquilerVehiculo.Nit = comboBoxNit.Text;
            alquilerVehiculo.Placa = comboBoxPlaca.Text;
            alquilerVehiculo.FechaAlquiler = dateTimePickerAlquiler.Value;
            alquilerVehiculo.FechaDevolucion = dateTimePickerDevolucion.Value;

            AlquileresArchivo alquilerArchivo = new AlquileresArchivo();
            alquilerArchivo.Guardar("../../Alquileres.json", alquilerVehiculos);
            Mostrar();
        }
    }
}
