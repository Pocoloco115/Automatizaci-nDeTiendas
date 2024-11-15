using AutomatizaciónDeTiendas.Estructuras;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutomatizaciónDeTiendas.Formularios
{
    public partial class CrearCuenta : Form
    {
        public CrearCuenta()
        {
            InitializeComponent();
        }

        private void btnGenerarId_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();

            int id = rnd.Next(100000, 999999);

            txtId.Text = id.ToString();
        }

        private void btnCrearCuenta_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombre.Text) ||
                string.IsNullOrEmpty(txtPassword.Text) ||
                string.IsNullOrEmpty(txtId.Text))
            {
                MessageBox.Show("Completa los campos tio");
            }
            else if(txtPassword.Text != txtConfirmacion.Text)
            {
                MessageBox.Show("Ingrese su contraseña correctamente");
            }
            else
            {
                string nombre = txtNombre.Text;
                string password = txtPassword.Text;
                int id = Convert.ToInt32(txtId.Text);
                Cliente cliente = new Cliente(id, nombre, password);
            }

        }

        private void CrearCuenta_Load(object sender, EventArgs e)
        {

        }
    }
}
