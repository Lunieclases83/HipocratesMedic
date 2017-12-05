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
    public partial class Medicamentos : Form
    {
        public Medicamentos()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Controles.ControlMedicamento.LlenarTablaComponenteXMedicamento(TablaComponentes, textBoxID.Text);
            Controles.ControlMedicamento.LlenarTablasSintomaXMedicamento(TablaSintomas, textBoxID.Text);

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void Medicamentos_Load(object sender, EventArgs e)
        {
            Controles.ControlMedicamento.LlenarTablaMedicamentos(TablaMedicamentos);
           
        }

        private void Medicamentos_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            (TablaMedicamentos.DataSource as DataTable).DefaultView.RowFilter = string.Format("Nombre_Medicamento LIKE '{0}%' OR Nombre_Medicamento  LIKE '% {0}%'", txtBuscar.Text);
        }

        private void TablaMedicamentos_Click(object sender, EventArgs e)
        {
           textBoxID.Text = TablaMedicamentos.CurrentRow.Cells[0].Value.ToString();
            textNomMedi.Text = TablaMedicamentos.CurrentRow.Cells[1].Value.ToString();
            textContenedor.Text = TablaMedicamentos.CurrentRow.Cells[3].Value.ToString();
        }
    }
}
