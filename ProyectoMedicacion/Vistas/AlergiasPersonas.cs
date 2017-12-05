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
    public partial class AlergiasPersonas : Form
    {
        public AlergiasPersonas()
        {
            InitializeComponent();
        }

        private void AlergiasPersonas_Load(object sender, EventArgs e)
        {
            

        }

        private void textIdPersona_TextChanged(object sender, EventArgs e)
        {
            Controles.ControlAlergia.LlenarTablaAlergias(TablaAlergiasPersona, textIdPersona.Text);
        }

        private void buttonBuscarPersona_Click(object sender, EventArgs e)
        {
            SubVistas.PersonasEnAlergias pea = new SubVistas.PersonasEnAlergias();
            pea.ShowDialog();
            pea.Activate();
        }

        private void AlergiasPersonas_Activated(object sender, EventArgs e)
        {
            if (Clases.Alergia.IdPersona <=0)
            {
                //Que no se cargen los datos de la persona
            }
            else
            {
                textIdPersona.Text = Clases.Alergia.IdPersona.ToString();
                textBoxNombrePersona.Text = Clases.Alergia.NombrePersona;
            }
            if (Clases.Componente.IdComponente <=0)
            {
                //Que no se cargen los datos del componente
                
            }
            else
            {
                textBoxNombreComponente.Text = Clases.Componente.NombreComponente;
                textBoxIdComponente.Text = Clases.Componente.IdComponente.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SubVistas.ComponentesEnAgregarMedicamentos ceam = new SubVistas.ComponentesEnAgregarMedicamentos();
            ceam.ShowDialog();
            ceam.Activate();
        }

        private void AlergiasPersonas_FormClosed(object sender, FormClosedEventArgs e)
        {
            Clases.Alergia.IdPersona = 0;
            Clases.Componente.IdComponente = 0;
            
        }

        private void buttonLimpiarPersona_Click(object sender, EventArgs e)
        {
            textBoxNombrePersona.Clear();
            textIdPersona.Clear();
        }

        private void buttonLimpiarComponente_Click(object sender, EventArgs e)
        {
            textBoxIdComponente.Clear();
            textBoxNombreComponente.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textIdPersona.Text =="" || textBoxIdComponente.Text =="" || textBoxNombreComponente.Text =="" || textBoxNombrePersona.Text =="")
            {
                MessageBox.Show("Debe buscar una persona y un componente médico.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Controles.ControlAlergia.ComprobarExistenciaDeAlergia(textBoxIdComponente.Text,textIdPersona.Text) ==true)
            {
                MessageBox.Show("Ya se habia establecido que esta persona es alergica al componente: "+textBoxNombreComponente.Text +".","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                DialogResult  Mensaje= MessageBox.Show("¿Está seguro que desea agregar esta Alergia?", "Mensaje de Confirmación", MessageBoxButtons.YesNo,MessageBoxIcon.Information);
                if (Mensaje ==DialogResult.No)
                {
                   
                }
                else if (Mensaje== DialogResult.Yes)
                {
                    Controles.ControlAlergia.GuardarAlergia(textIdPersona.Text.ToString(), textBoxIdComponente.Text.ToString());
                    MessageBox.Show("Operación realizada correctamente", "Alergia agregada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   
                    textBoxIdComponente.Clear();
                    textBoxNombreComponente.Clear();
                    Controles.ControlAlergia.LlenarTablaAlergias(TablaAlergiasPersona,textIdPersona.Text);
                }
                
            }
            

        }

        private void buttonEliminarComponenteAlergico_Click(object sender, EventArgs e)
        {
            if (textIdPersona.Text == "" || textBoxNombrePersona.Text == "")
            {
                MessageBox.Show("Debe buscar una persona.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (TablaAlergiasPersona.RowCount <= 0)
            {
                MessageBox.Show("Parece que está persona no tiene alergias.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (TablaAlergiasPersona.CurrentRow.Cells[0].Value.ToString() == "")
            {
                MessageBox.Show("Debe seleccionar un componente de la tabla de alergias para realizar esta operación.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult Mensaje = MessageBox.Show("¿Está seguro que desea eliminar el componente médico: '" + TablaAlergiasPersona.CurrentRow.Cells[1].Value.ToString() + "' de las Alergias de "+textBoxNombrePersona.Text+"?", "Mensaje de Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (Mensaje == DialogResult.No)
                {

                }
                else if (Mensaje == DialogResult.Yes)
                {
                    Controles.ControlAlergia.EliminarAlergia(textIdPersona.Text.ToString(), TablaAlergiasPersona.CurrentRow.Cells[0].Value.ToString());
                    MessageBox.Show("Operación realizada correctamente", "Alergia eliminada", MessageBoxButtons.OK, MessageBoxIcon.Information);

                  
                    Controles.ControlAlergia.LlenarTablaAlergias(TablaAlergiasPersona, textIdPersona.Text);
                }
            }
        }

        private void txtFiltrarBusqueda_TextChanged(object sender, EventArgs e)
        {
            (TablaAlergiasPersona.DataSource as DataTable).DefaultView.RowFilter = string.Format("Componente LIKE '{0}%' OR Componente LIKE '% {0}%'", txtFiltrarBusqueda.Text);
        }
    }
}
