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
            AlquileresArchivo alquilerArchivo = new AlquileresArchivo();
            alquilerVehiculos = alquilerArchivo.Leer("../../Alquileres.json");

            string placaSeleccionada = comboBoxPlaca.Text;
            DateTime nuevaFechaInicio = dateTimePickerAlquiler.Value;//Se guarda en variable para ver fecha
            DateTime nuevaFechaFin = dateTimePickerDevolucion.Value;

            // Ver si se puede alquilar
            bool conflicto = alquilerVehiculos.Any(a => a.Placa == placaSeleccionada &&
                (
                    (nuevaFechaInicio >= a.FechaAlquiler && nuevaFechaInicio <= a.FechaDevolucion) || // nueva fecha inicia durante un alquiler existente
                    (nuevaFechaFin >= a.FechaAlquiler && nuevaFechaFin <= a.FechaDevolucion) ||       // nueva fecha termina durante un alquiler existente
                    (nuevaFechaInicio <= a.FechaAlquiler && nuevaFechaFin >= a.FechaDevolucion)       // nuevo alquiler abarca completamente uno existente
                )
            );

            if (conflicto)
            {
                MessageBox.Show("El vehículo ya está alquilado en las fechas seleccionadas.", "Error de disponibilidad", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Si no hay conflicto, se procede a guardar
            AlquilerVehiculos alquilerVehiculo = new AlquilerVehiculos();
            alquilerVehiculo.Nit = comboBoxNit.Text;
            alquilerVehiculo.Placa = comboBoxPlaca.Text;
            alquilerVehiculo.FechaAlquiler = nuevaFechaInicio;
            alquilerVehiculo.FechaDevolucion = nuevaFechaFin;
            alquilerVehiculo.KilometrosRecorridos = Convert.ToDecimal(maskedTextBoxKMrecorrido.Text);
            

            alquilerVehiculos.Add(alquilerVehiculo);
            alquilerArchivo.Guardar("../../Alquileres.json", alquilerVehiculos);
            Mostrar();
            MessageBox.Show("Alquiler registrado con éxito.", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void maskedTextBoxKMrecorrido_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
