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
    public partial class GestionPersonas : Form
    {
        public GestionPersonas()
        {
            InitializeComponent();
        }

        private void GestionPersonas_Load(object sender, EventArgs e)
        {
            Controles.ControlPersona.LlenarTablaPersonaEnAlergias(tablaGestionarPersona);
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            (tablaGestionarPersona.DataSource as DataTable).DefaultView.RowFilter = string.Format("Nombre_Persona LIKE '{0}%' OR Nombre_Persona LIKE '% {0}%' OR Apellido_Persona LIKE '{0}%' OR Apellido_Persona LIKE '% {0}%' OR Cedula_Persona LIKE '{0}%' OR Cedula_Persona LIKE '% {0}%'", txtBuscar.Text);
        }

        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tablaGestionarPersona_MouseClick(object sender, MouseEventArgs e)
        {
            txtID.Text = tablaGestionarPersona.CurrentRow.Cells[0].Value.ToString();
            txtNombre.Text = tablaGestionarPersona.CurrentRow.Cells[1].Value.ToString();
            txtApellido.Text = tablaGestionarPersona.CurrentRow.Cells[2].Value.ToString();
            txtEdad.Text = tablaGestionarPersona.CurrentRow.Cells[3].Value.ToString();
            txtSexo.Text = tablaGestionarPersona.CurrentRow.Cells[4].Value.ToString();
            txtTipo_Persona.Text = tablaGestionarPersona.CurrentRow.Cells[5].Value.ToString();
            txtCedula.Text = tablaGestionarPersona.CurrentRow.Cells[6].Value.ToString();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtID.Text =="" || txtNombre.Text =="" ||txtApellido.Text =="" || txtEdad.Text =="")
            {
                MessageBox.Show("Rellene los campos vacios","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult mensaje = MessageBox.Show("Desea guardar los cambios?", "Aplicar Cambios", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (mensaje == DialogResult.No)
                {

                }

                else if (mensaje == DialogResult.Yes)
                {
                    Controles.ControlPersona.ActualizarPersona(txtID.Text, txtNombre.Text, txtApellido.Text, txtEdad.Text, txtTipo_Persona.Text, txtSexo.Text, txtCedula.Text);
                    MessageBox.Show("Operación Completada satisfactoriamente", "Cambios Aplicados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Controles.ControlPersona.LlenarTablaPersonaEnAlergias(tablaGestionarPersona);
                    txtID.Clear();
                    txtNombre.Clear();
                    txtApellido.Clear();
                    txtEdad.Clear();
                    txtCedula.Clear();
                }

                
            }
        }
    }
}
