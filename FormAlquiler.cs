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
    }
}
