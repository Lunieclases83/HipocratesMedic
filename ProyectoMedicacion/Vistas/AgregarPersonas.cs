using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoMedicacion.Vistas
{
    public partial class AgregarPersonas : Form
    {
        public AgregarPersonas()
        {
            InitializeComponent();
        }

        private void AgregarPersonas_Load(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtCedula.Clear();
            txtEdad.Clear();
            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text =="" || txtApellido.Text ==""|| txtCedula.Text =="" ||txtEdad.Text =="")
            {
                MessageBox.Show("Rellene los campos vacios.","Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                Controles.ControlPersona.GuardarNuevaPersona(txtNombre.Text, txtApellido.Text, txtEdad.Text, txtTipo_Persona.Text, txtSexo.Text, txtCedula.Text);

                txtNombre.Clear();
                txtApellido.Clear();
                txtCedula.Clear();
                txtEdad.Clear();
                MessageBox.Show("Operación realizada correctamente.", "Completado", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
