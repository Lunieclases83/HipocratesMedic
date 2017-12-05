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
    public partial class AgregarMedicamento : Form
    {
        public AgregarMedicamento()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void AgregarMedicamento_Load(object sender, EventArgs e)
        {

        }

        private void botonGuardar_Click(object sender, EventArgs e)
        {
            if (textNombreMedicamento.Text =="" || TextIndicacionesMedicamento.Text =="" || TextDosisMedicamento.Text =="" )
            {
                MessageBox.Show("Por favor complete los datos del Medicamento.", "Campos Vacios", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (ListaSintomas.SelectedItems.Count <= 0)
            {
                MessageBox.Show("Necesita seleccionar almenos un sintoma para el Medicamento.", "Campos Vacios", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (dataGridView1.RowCount <=0)
            {
                MessageBox.Show("Necesita agregar almenos un componente para el Medicamento.", "Campos Vacios", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            else
            {

                DialogResult dialogResult = MessageBox.Show("¿Esta seguro guardar este Medicamento?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialogResult == DialogResult.Yes)
                {
                    Controles.ControlMedicamento.InsertarMedicamento(textNombreMedicamento.Text, TextFechaExpiracion.Text, TextIndicacionesMedicamento.Text, TextDosisMedicamento.Text, TextContenedorMedicamento.Text);

                    Controles.ControlSintoma.AgregarSintomasAMedicamento(ListaSintomas, Clases.Medicamento.IdMedicamento);

                    Controles.ControlComponente.InsertarComponenteAMedicamento(dataGridView1, Clases.Medicamento.IdMedicamento.ToString());

                    MessageBox.Show("El proceso se completó satisfactoriamente.", "Medicamento Almacenado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpiarcampos();
                    textBoxComponenteAAgregar.Clear();
                }

                else if (dialogResult == DialogResult.No)
                {
                    //no hace nada
                }
                
            }

           
        }


        public void limpiarcampos()
        {
            textNombreMedicamento.Clear();
            TextDosisMedicamento.Clear();
            TextIndicacionesMedicamento.Clear();
            while (dataGridView1.Rows.Count > 0)
            {
                dataGridView1.Rows.RemoveAt(0);
            }
            for (int i = 0; i < ListaSintomas.Items.Count; i++)
            {
                ListaSintomas.SetItemChecked(i, false);
            }
        }

        private void BuscarComponente(object sender, EventArgs e)
        {
            SubVistas.ComponentesEnAgregarMedicamentos ceam = new SubVistas.ComponentesEnAgregarMedicamentos();
            ceam.Activate();
            ceam.ShowDialog();
        }

        private void AgregarMedicamento_Activated(object sender, EventArgs e)
        {
            //este evento trae el compoente desde el formulario de busqueda hasta este.
            if (Clases.Componente.IdComponente<=0)
            {
                //que no haga nada
            }
            
            else
            {
                textBoxComponenteAAgregar.Text = Clases.Componente.NombreComponente;
            }
            if (textBoxComponenteAAgregar.Text == "")
            {
                buttonAgregarComponenteALista.Enabled = false;
                buttonBuscarComponente.Enabled = true;
            }
            
        }

        private void buttonAgregarComponenteALista_Click(object sender, EventArgs e)
        {
            if (textBoxComponenteAAgregar.Text =="")
            {
                MessageBox.Show("Debe buscar un componente para agregarlo a la lista.", "Busque un Componente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                bool ExistenciaDeComponente = false;
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    object val = row.Cells[1].Value;
                    if (val.ToString() == textBoxComponenteAAgregar.Text)
                    {
                        MessageBox.Show("Este elemento ya está en al lista.", "El componente está agregado", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        ExistenciaDeComponente = true;
                        textBoxComponenteAAgregar.Clear();
                        break;
                    }
                }
                if (!ExistenciaDeComponente)
                {
                    dataGridView1.Rows.Add(Clases.Componente.IdComponente, Clases.Componente.NombreComponente);
                    textBoxComponenteAAgregar.Clear();
                }

            
            }

            
        }

        private void textBoxComponenteAAgregar_TextChanged(object sender, EventArgs e)
        {
            if (textBoxComponenteAAgregar.Text=="")
            {
                buttonAgregarComponenteALista.Enabled = false;
                buttonBuscarComponente.Enabled = true;
            }
            else
            {

                buttonAgregarComponenteALista.Enabled = true;
                buttonBuscarComponente.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(dataGridView1.RowCount.ToString());
        }

        private void buttonEliminarComponente_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount >0)
            {

                DialogResult dialogResult = MessageBox.Show("¿Esta seguro que desea eliminar este componente?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialogResult == DialogResult.Yes)
                {
                    foreach (DataGridViewCell oneCell in dataGridView1.SelectedCells)
                    {
                        if (oneCell.Selected)
                            dataGridView1.Rows.RemoveAt(oneCell.RowIndex);
                        
                    }
                    Clases.Componente.NombreComponente = "";
                }
                else if (dialogResult == DialogResult.No)
                {
                    textBoxComponenteAAgregar.Clear();//do something else
                    Clases.Componente.NombreComponente = "";
                }
            }
                                  
        }

        private void textBoxComponenteAAgregar_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            textBoxComponenteAAgregar.Clear();
        }

        private void buttonLimpiarCampos_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Esta seguro que desea limpiar todos los campos?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
               limpiarcampos();
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }

            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Esta seguro que desea eliminar todos los componentes agregados?", "Alerta", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                while (dataGridView1.Rows.Count > 0)
                {
                    dataGridView1.Rows.RemoveAt(0);
                }

            }
            else if (dialogResult == DialogResult.No)
            {
                
            }
        }

        private void buttonDeseleccionarChecks_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Esta seguro que desea deseleccionar todos sintomas?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                for (int i = 0; i < ListaSintomas.Items.Count; i++)
                {
                    ListaSintomas.SetItemChecked(i, false);
                }

            }
            else if (dialogResult == DialogResult.No)
            {

            }

            
        }

        private void AgregarMedicamento_FormClosed(object sender, FormClosedEventArgs e)
        {
            Clases.Componente.IdComponente = 0;
        }

        private void buttonVerMedicamentos_Click(object sender, EventArgs e)
        {
           
            SubVistas.Medicamentos m = new SubVistas.Medicamentos();
            m.ShowDialog();
        }
    }
    }

