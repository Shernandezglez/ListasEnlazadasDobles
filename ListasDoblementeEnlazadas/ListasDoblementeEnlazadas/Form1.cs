using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListasDoblementeEnlazadas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Estructura cat = new Estructura();

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            try
            {
                ClaseBase nuevo = new ClaseBase(txtProducto.Text, txtAlumno.Text, txtVehiculo.Text, Convert.ToInt32(txtContacto.Text), Convert.ToInt32(txtCodigo.Text));
                cat.agregarObjeto(nuevo);
                txtAlumno.Clear();
                txtContacto.Clear();
                txtProducto.Clear();
                txtVehiculo.Clear();
                txtCodigo.Clear();
            }
            catch (FormatException)
            {
                DialogResult r = MessageBox.Show("Llena todos los campos", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            txtCatalogo.Text = cat.reporte();
        }

        private void btnReporteInverso_Click(object sender, EventArgs e)
        {
            txtCatalogo.Text = cat.reporteInverso();
        }

        private void btnEliminarPrimero_Click(object sender, EventArgs e)
        {
            cat.eliminarPrimero();
        }

        private void btnEliminarUltimo_Click(object sender, EventArgs e)
        {
            cat.eliminarUltimo();
        }

        private void btnInvertir_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            cat.eliminarDatoPorCodigo(Convert.ToInt32(txtCodigo.Text));
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            cat.buscarPorCodigo(Convert.ToInt32(txtCodigo.Text));
        }
    }
    
}
