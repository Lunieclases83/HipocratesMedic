using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoMedicacion.Vistas
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        public void DesbloquearModulos()
        {
            panelUsuarios.Enabled = false;
            panelPersonas.Enabled = false;
            panelMedicamentosComposicion.Enabled = false;
            panelConsultaMedica.Enabled = false;
            panelProveedores.Enabled = false;
            panelCompras.Enabled = false;
            panelInventario.Enabled = false;


            //string Modulo = Controles.ControlPermiso.PermisosUsuario[0].ToString();
            int totalpermisos = Controles.ControlPermiso.PermisosUsuario.Count();
            for (int i = 0; i < totalpermisos; i++)
            {
                /////modulo usuarios
                if (Controles.ControlPermiso.PermisosUsuario[i] == "Módulo de Usuarios")
                {
                    panelUsuarios.Enabled = true;
                }
             

                if (Controles.ControlPermiso.PermisosUsuario[i] == "Módulo de Personas")
                {
                    panelPersonas.Enabled = true;
                }
              
                //modulo medicamentos y composicion

                if (Controles.ControlPermiso.PermisosUsuario[i] == "Módulo de Medicamentos y Composión")
                {
                    panelMedicamentosComposicion.Enabled = true;
                }
                
                if (Controles.ControlPermiso.PermisosUsuario[i] == "Módulo de Consulta Médica")
                {
                    panelConsultaMedica.Enabled = true;
                }
                
                //proveedores
                if (Controles.ControlPermiso.PermisosUsuario[i] == "Módulo de Proveedores")
                {
                    panelProveedores.Enabled = true;
                }
                
                if (Controles.ControlPermiso.PermisosUsuario[i] == "Módulo de Compras")
                {
                    panelCompras.Enabled = true;
                }
                
                ///modulo de inventario
                if (Controles.ControlPermiso.PermisosUsuario[i] == "Módulo de Inventario")
                {
                    panelInventario.Enabled = true;
                }

                timer1.Start();

            }

        }

        public void CargarBienvienida()
        {
            try
            {
                Data_Persistance.Conexion.CerrarConexion();
                Data_Persistance.Conexion.AbrirConexion();

                SqlCommand ComandoSQL2 = new SqlCommand("SELECT Nombre_Persona, Apellido_Persona from Persona, Usuario WHERE Usuario.Id_Persona = '" + Convert.ToInt32(Clases.Usuario.IdPersona) + "' AND Persona.Id_Persona = '" + Clases.Usuario.IdPersona + "'", Data_Persistance.Conexion.conn);

                ComandoSQL2.ExecuteNonQuery();
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(ComandoSQL2);
                da.Fill(ds, "Usuario");
                DataRow dro;
                dro = ds.Tables["Usuario"].Rows[0];

                textBoxNombre.Text = dro["Nombre_Persona"].ToString() + " " + dro["Apellido_Persona"];
                textIdUsu.Text = Clases.Usuario.IdUsuario.ToString();
                textBoxUsuario.Text = Clases.Usuario.Nombre;

                

            }
            catch (Exception e) { MessageBox.Show(e.ToString()); }
            finally { Data_Persistance.Conexion.CerrarConexion(); }
        }

            private void Home_Load(object sender, EventArgs e)
        {
           Controles.ControlPermiso cp = new Controles.ControlPermiso();
           cp.CargarPermisosUsuario();
           DesbloquearModulos();
            CargarBienvienida();
           
        }

        private void buttonUsuarios_Click(object sender, EventArgs e)
        {
            Vistas.AgregarUsuario au = new Vistas.AgregarUsuario();
            au.ShowDialog();
            
        }

        private void Home_FormClosed(object sender, FormClosedEventArgs e)
        {
            Login lg = new Login();
            lg.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            Vistas.GestionUsuarios gu = new Vistas.GestionUsuarios();
            gu.ShowDialog();
            gu.Activate();

        }

        private void Home_Activated(object sender, EventArgs e)
        {
            Controles.ControlPermiso cp = new Controles.ControlPermiso();

            cp.CargarPermisosUsuario();

            DesbloquearModulos();

        }

        private void Home_Enter(object sender, EventArgs e)
        {
            
        }

        private void Home_MouseHover(object sender, EventArgs e)
        {
            
           
        }

        private void Home_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void Home_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Vistas.AgregarPersonas ap = new AgregarPersonas();
           // this.Hide();
            ap.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //this.Hide();
            Vistas.GestionPersonas gp = new GestionPersonas();
            gp.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Vistas.AgregarMedicamento am = new AgregarMedicamento();
            am.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //this.Hide();
            Vistas.AlergiasPersonas ap = new AlergiasPersonas();
            ap.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Vistas.ConsultaMedica cm = new Vistas.ConsultaMedica();
            cm.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.labelHora.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }
    }
}
