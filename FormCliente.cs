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
    public partial class FormCliente : Form
    {
        List<Clientes> clientes = new List<Clientes>();
        public FormCliente()
        {
            InitializeComponent();
        }

        private void FormCliente_Load(object sender, EventArgs e)
        {
            Mostrar();
        }

       
        private void Mostrar()
        {
            ClientesArchivo clienteArchivo = new ClientesArchivo();
            clientes = clienteArchivo.Leer("../../Clientes.json");
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = clientes;
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
            Clientes cliente = new Clientes();
            cliente.Nit = textBoxNit.Text;
            cliente.Nombre = textBoxNombre.Text;
            cliente.Direccion = textBoxDireccion.Text;
            clientes.Add(cliente);

            ClientesArchivo clientesArchivo = new ClientesArchivo();
            clientesArchivo.Guardar("../../Clientes.json", clientes);//Funcion guardar de clase ClientesArchivo
            Mostrar();
        }

        /*
         * Empleado empleado = new Empleado();
            empleado.noEmpleado = Convert.ToInt16(numericUpDown1.Value);
            empleado.nombre = textBox1.Text;
            empleado.sueldo = Convert.ToDecimal(maskedTextBox2.Text);
            empleados.Add(empleado);

            EmpleadoArchivo empleadoArchivo = new EmpleadoArchivo();
            empleadoArchivo.Guardar("../../Empleados.json", empleados);//Funcion guardar de clase EmpleadoArchivo
            Mostrar();
         */

    }
}
