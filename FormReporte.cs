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
    public partial class FormReporte : Form
    {
        List<ReporteVehiculos> reportesVehiculo = new List<ReporteVehiculos>();
        List<AlquilerVehiculos> alquilerVehiculos = new List<AlquilerVehiculos>();
        List<Vehiculo> vehiculos = new List<Vehiculo>();
        List<Clientes> clientes = new List<Clientes>();
        public FormReporte()
        {
            InitializeComponent();
        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            Form1 formuMenu = new Form1();
            formuMenu.Show();
            this.Hide();
        }
        private void cargarClientes()
        {
            ClientesArchivo clientesArchivo = new ClientesArchivo();
            clientes = clientesArchivo.Leer("../../Clientes.json");
        }

        private void cargarVehiculos()
        {
            VehiculoArchivo vehiculoArchivo = new VehiculoArchivo();
            vehiculos = vehiculoArchivo.Leer("../../Vehiculos.json");
        }

        private void cargarAlquileres()
        {
            AlquileresArchivo alquileresArchivo = new AlquileresArchivo();
            alquilerVehiculos = alquileresArchivo.Leer("../../Alquileres.json");
        }

        /*private void mayorKMrecorridos()
        {
            foreach (var vehiculo in vehiculos)
            {
                foreach(var alquilervehi in alquilerVehiculos)
                {
                    if ((vehiculo.Placa == alquilervehi.Placa))
                    {
                        decimal sumadeKilometros = alquilervehi.KilometrosRecorridos + sumadeKilometros.Value;
                    }
                }
            }


            AlquilerVehiculos mayorRecorrido = alquilerVehiculos.OrderByDescending(a => a.KilometrosRecorridos).First();
            labelAlquiler.Text = "El mayor recorrido en km es: "+mayorRecorrido.ToString();
        }*/


        private void buttonMostrarReporte_Click(object sender, EventArgs e)
        {
            foreach (var cliente in clientes)
            {
                foreach (var vehiculo in vehiculos)
                {
                    foreach (var alquilervehi in alquilerVehiculos)
                    {
                        if ((cliente.Nit == alquilervehi.Nit)&&(vehiculo.Placa == alquilervehi.Placa))
                        {
                            ReporteVehiculos reporteVehiculo = new ReporteVehiculos();
                            reporteVehiculo.NombreCliente = cliente.Nombre;
                            reporteVehiculo.Placa = vehiculo.Placa;
                            reporteVehiculo.Marca = vehiculo.Marca;
                            reporteVehiculo.Modelo = vehiculo.Modelo;
                            reporteVehiculo.Color = vehiculo.Color;
                            reporteVehiculo.PrecioKilometro = vehiculo.PrecioKilometro;
                            reporteVehiculo.FechaDevolucion = alquilervehi.FechaDevolucion;
                            reporteVehiculo.TotalPago = vehiculo.PrecioKilometro * alquilervehi.KilometrosRecorridos;
                            reportesVehiculo.Add(reporteVehiculo);
                        }
                    }
                }
            }
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = reportesVehiculo;
            dataGridView1.Refresh();


            AlquilerVehiculos mayorRecorrido = alquilerVehiculos.OrderByDescending(a => a.KilometrosRecorridos).First();
            labelAlquiler.Visible = true;
            labelAlquiler.Text = "El mayor recorrido en de kilometros es de: " +mayorRecorrido.KilometrosRecorridos.ToString()+ " km";

        }

        private void FormReporte_Load(object sender, EventArgs e)
        {
            cargarClientes();
            cargarVehiculos();
            cargarAlquileres();
        }
    }
}
