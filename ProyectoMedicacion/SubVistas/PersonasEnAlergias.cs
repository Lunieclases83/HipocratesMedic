using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoMedicacion.SubVistas
{
    public partial class PersonasEnAlergias : Form
    {
        public PersonasEnAlergias()
        {
            InitializeComponent();
        }

        private void PersonasEnAlergias_Load(object sender, EventArgs e)
        {
            Controles.ControlPersona.LlenarTablaPersonaEnAlergias(TablaPersonas);
        }

        private void textBoxFiltrarBusquedaPersona_TextChanged(object sender, EventArgs e)
        {
            (TablaPersonas.DataSource as DataTable).DefaultView.RowFilter = string.Format("Nombre_Persona LIKE '{0}%' OR Nombre_Persona LIKE '% {0}%' OR Apellido_Persona LIKE '{0}%' OR Apellido_Persona LIKE '% {0}%' OR Cedula_Persona LIKE '{0}%' OR Cedula_Persona LIKE '% {0}%'", textBoxFiltrarBusquedaPersona.Text);

            
        }

        private void TablaPersonas_Click(object sender, EventArgs e)
        {
            try
            {
                textBoxIdPersona.Text = TablaPersonas.CurrentRow.Cells[0].Value.ToString();
                textBoxNombrePersona.Text = TablaPersonas.CurrentRow.Cells[1].Value.ToString() +" "+ TablaPersonas.CurrentRow.Cells[2].Value.ToString();
            }
            catch (Exception)    { }
            
        }

        private void TablaPersonas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ButtonLimpiar_Click(object sender, EventArgs e)
        {
            textBoxIdPersona.Clear();
            textBoxNombrePersona.Clear();
            textBoxFiltrarBusquedaPersona.Clear();
           
        }

        private void buttonSeleccionar_Click(object sender, EventArgs e)
        {
            if (textBoxNombrePersona.Text =="" || textBoxIdPersona.Text =="")
            {
                MessageBox.Show("Debe seleccionar una persona.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Clases.Alergia.IdPersona = Convert.ToInt32(textBoxIdPersona.Text);
                Clases.Alergia.NombrePersona = textBoxNombrePersona.Text;
                this.Close();

            }
        }
    }
}
